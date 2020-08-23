using System;
using System.Collections.Generic;
using System.Text;

namespace DolphinFacebook
{ 
    public interface IFacebookClient
    {
        event Action<string> NewWallPost;

        void WriteNewWallPost(string wallPost);

        void Subscribe(IFacebookClient publisher);

        void Unsubscribe(IFacebookClient publisher);
    }

}
