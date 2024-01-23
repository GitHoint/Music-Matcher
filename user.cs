using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Matcher
{
    internal class User
    {
        private List<string> savedPlaylists;
        private bool   didUserLogin;
        private string username;
        private string password;
        private string currentPlaylist;
        private int    highScore;
        private int    timesPlayed;

        public void SetData(string givenUsername, string givenPass, string timesPlayed, string highscore)
        {
            username = givenUsername;
            password = givenPass;
            didUserLogin = true;
            this.timesPlayed = Convert.ToInt32(timesPlayed);
            this.highScore = Convert.ToInt32(highscore);
        }
        public void SetAsGuestUser()
        {
            didUserLogin = false;
        }
        public string GetUsername()
        {
            return username;
        }
        public int GetPlayed()
        {
            return timesPlayed;
        }
        public int GetScore()
        {
            return highScore;
        }
        public string GetPlaylistName()
        {
            return currentPlaylist;
        }
        public bool GetLoginStatus()
        {
            return didUserLogin;
        }
        public void SetCurrentPlaylist(string givenPlaylist)
        {
            currentPlaylist = givenPlaylist;
        }
        public void LoadSavedPlaylists(List<string> playlists)
        {
            savedPlaylists = playlists;
        }
        
        public List<string> GetSavedPlaylists()
        {
            return savedPlaylists;
        }
        public void UpdateResults(int score)
        {
            if (score > highScore)
            {
                highScore = score;
            }
            timesPlayed++;
        }
        public void SaveToFile()
        {
            string path = "userCredentials.txt";
            List<string> users = File.ReadAllLines(path).ToList();
            //Username--Password--Highscore--Games Played
            foreach(string user in users)
            {
                string[] parts = user.Split(", ");
                if (parts[0] == username)
                {
                    users.Remove(user);
                    users.Add(username + ", " + password + ", " + highScore + ", " + timesPlayed);
                    break;
                }
            }
            File.WriteAllLines(path, users);
        }
    }
}
