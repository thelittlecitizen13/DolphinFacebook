using System;
using System.Runtime.InteropServices;

namespace DolphinFacebook
{
    public class DolphinsFacebookClient : IFacebookClient
    {
        public event Action<string> NewWallPost;
        public IDisplay Display;
        public DolphinsFacebookClient(IDisplay display)
        {
            Display = display;
        }

        public void Subscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost += Display.DisplayWallPost;
        }

        public void Unsubscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost -= Display.DisplayWallPost;
        }

        public void WriteNewWallPost(string wallPost)
        {
            Display.DisplayWallPost(wallPost);
            NewWallPost?.Invoke(wallPost);
        }

    }
}
