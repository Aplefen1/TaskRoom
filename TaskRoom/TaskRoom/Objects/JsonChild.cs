using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRoom.Objects
{
    public class JsonChild
    {
        //attributes given in the JSON string
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public int age { get; set; }
        public int points { get; set; }
        //all lower case because of python syntax.
    }
}
