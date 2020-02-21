using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRoom.Objects
{
    class LeaderboardRoot
    {
        public List<Child> children { get; set; }
    };
    public class Child
    {
        public string name { get; set; }
        public int points { get; set; }
    }
}
