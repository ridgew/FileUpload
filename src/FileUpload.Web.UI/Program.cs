using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace FileUpload
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        //ASP.NET Core 2.0中如何更改Http请求的maxAllowedContentLength最大值
        //https://www.cnblogs.com/OpenCoder/p/9786020.html

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel(options =>
                {
                    options.Limits.MaxRequestBufferSize = 1048576;
                    options.Limits.MaxRequestLineSize = 1048576;
                    options.Limits.MaxRequestBodySize = null;
                })
                .UseStartup<Startup>()
                .Build();
    }
}
