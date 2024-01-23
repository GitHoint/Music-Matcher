using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Music_Matcher
{
    internal class Playlist
    {
        public Random rng = new Random();
        private List<string> playlist;
        private int playlistLength;
        private string currentlySelected;
        private string songName;
        private string artist;

        public string GetSongName()
        {
            return songName;
        }

        public int GetPlaylistLength()
        {
            return playlistLength;
        }
        public string GetArtist()
        {
            return artist;
        }
        public void SetPlaylistData(List<string> givenList)
        {
            playlist = givenList;
            playlistLength = playlist.Count;
        }

        public void SelectSong()
        {
            currentlySelected = playlist[rng.Next(0, playlistLength)];
            playlist.Remove(currentlySelected);
            playlistLength = playlist.Count;
            ParseSelected();
        }

        public void ParseSelected() //Split Song And Artist
        {
            int point = currentlySelected.IndexOf(" - ");
            artist = currentlySelected.Substring(0, point);

            songName = currentlySelected.Substring(point + 3);
            ClearSongName();
        }
        
        public void ClearSongName() //Remove extra songName Info
        {
            if (songName.Contains(" - "))
            {
                int point = songName.IndexOf(" - ");
                songName = songName.Substring(0, point);    
            }
            else if (songName.Contains(" ("))
            {
                int point = songName.IndexOf(" (");
                songName = songName.Substring(0, point);
            }
            string[] puncToRemove = { ",", ".", "?", "!", "'", ":", ";" };
            foreach(string punc in puncToRemove)
            {
                if (songName.Contains(punc))
                {
                    songName = songName.Replace(punc, "");
                }
            }
        }
        public string GetSongNameSpaces()
        {
            string songAsSpaces = "";
            songName = songName.Trim();
            foreach (char ch in songName)
            {
                if (ch == ' ')
                {
                    songAsSpaces += ch;
                }
                else
                {
                    songAsSpaces += "_";
                }
            }
            return songAsSpaces;
        }
        public string RevealFirstChar()
        {
            List<char> charsToReplace = GetFirstChars();
            List<int> indexesToReplace = GetCharIndex();
            string output = "";
            int current = 0;
            while (true)
            {
                for (int i = 0; i < songName.Length; i++)
                {
                    if (current < charsToReplace.Count)
                    {
                        if (i == indexesToReplace[current])
                        {
                            output += charsToReplace[current];
                            current++;
                        }
                        else if (songName[i] == ' ')
                        {
                            output += songName[i];
                        }
                        else
                        {
                            output += '_';
                        }
                    }
                    else
                    {
                        if (songName[i] == ' ')
                        {
                            output += songName[i];
                        }
                        else
                        {
                            output += '_';
                        }
                    }
                }
                break;
            }
            return output;
        }

        private List<char> GetFirstChars()
        {
            string[] words = songName.Split(" ");
            List<char> chars = new List<char>();
            foreach (var word in words)
            {
                chars.Add(word[0]);
            }
            return chars;
        }
        private List<int> GetCharIndex()
        {
            List<int> indexes = new List<int>();
            indexes.Add(0);
            while (true)
            {
                for (int i = 0; i < songName.Length; i++)
                {
                    if (songName[i] == ' ')
                    {
                        i++;
                        indexes.Add(i);
                    }
                }
                break;
            }
            return indexes;
        }
    }
}
