namespace DolphinFacebook
{
    public interface IFacebookClientFactory
    {
        IFacebookClient CreateClient(IDisplay display);
    }



    }
