using System;

namespace DolphinFacebook
{
    public class DolphinsFacebookClient : IFacebookClient
    {
        public event Action<string> NewWallPost;

        public void Subscribe(IFacebookClient publisher)
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe(IFacebookClient publisher)
        {
            throw new NotImplementedException();
        }

        public void WriteNewWallPost(string wallPost)
        {
            throw new NotImplementedException();
        }
    }
}
