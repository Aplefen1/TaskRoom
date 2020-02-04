using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRoom.Objects
{
    public class GlobalSettings
    {
        private bool loginStatus;
        private string fontSize;
        Dictionary<string, string> loginInformation;
        Child currentChild;
        List<string> retrivedClasses = new List<string>();

        public void setLoginStatus(bool status)
        {
            this.loginStatus = true;
        }
        public void setCurrentChild(Child child)
        {
            this.currentChild = child;
        }


    }
}
