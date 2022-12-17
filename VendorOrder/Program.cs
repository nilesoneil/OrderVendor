using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace VendorOrder
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .Build();

      host.Run();
    }
  }
}