using System;

namespace DolphinFacebook
{
    public class Display : IDisplay
    {
        private string _fullName;
        public Display(string name)
        {
            _fullName = name;
        }
        public void DisplayWallPost(string wallPost)
        {
            Console.WriteLine($"{_fullName}: {wallPost}");
        }
    }
}
