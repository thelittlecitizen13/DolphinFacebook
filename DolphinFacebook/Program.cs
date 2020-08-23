namespace DolphinFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new Display("Assa");
            Display d2 = new Display("Yuval");
            Display d3 = new Display("Idan");
            FacebookClientFactory factory = new FacebookClientFactory();
            DolphinsFacebookClient AssaWall = (DolphinsFacebookClient)factory.CreateClient(d1);
            DolphinsFacebookClient YuvalWall = (DolphinsFacebookClient)factory.CreateClient(d2);
            DolphinsFacebookClient IdanWall = (DolphinsFacebookClient)factory.CreateClient(d3);
            AssaWall.Subscribe(YuvalWall);
            AssaWall.Subscribe(IdanWall);
            IdanWall.Subscribe(YuvalWall);
            IdanWall.Subscribe(AssaWall);
            YuvalWall.WriteNewWallPost("Mamas enough with the number 6!!!!");
            AssaWall.WriteNewWallPost("Enough with those avatars on facebook! Where are the indian people who build pools??");
        }
    }
}
