using NetModular.Lib.Host.Web;

namespace NetModular.Module.Forum.WebHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new HostBuilder().Run<Startup>(args);
        }
    }
}
