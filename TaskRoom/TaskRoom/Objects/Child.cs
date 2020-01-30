using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRoom
{
    public class Child
    {
        int Id;
        string Name;
        string LastName;
        int Age;
        int Points;
        private string Username;
        private string Password;

        public Child(int id, string fname, string lname, int age, int points, string username, string password)
        {
            this.Id = id;
            this.Name = fname;
            this.LastName = lname;
            this.Age = age;
            this.Points = points;
            this.Username = username;
            this.Password = password;
        }

        public void IncreasePoints(int NewPoints)
        {
            this.Points += NewPoints;
        }

        private string GetPassword()
        {
            return Password;
        }
    }
}