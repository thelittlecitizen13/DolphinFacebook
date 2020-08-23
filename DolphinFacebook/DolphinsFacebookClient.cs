using System;
using System.Runtime.InteropServices;

namespace DolphinFacebook
{
    public class DolphinsFacebookClient : IFacebookClient
    {
        private string _fullName;
        public event Action<string> NewWallPost;
        public DolphinsFacebookClient(string fullName)
        {
            _fullName = fullName;
        }

        public void Subscribe(IFacebookClient publisher)
        {
            NewWallPost += publisher.WriteNewWallPost;
        }

        public void Unsubscribe(IFacebookClient publisher)
        {
            NewWallPost -= publisher.WriteNewWallPost;
        }

        public void WriteNewWallPost(string wallPost)
        {
            
        }
        public void ShowWallPost(string wallPost)
        {

        }
    }
}
