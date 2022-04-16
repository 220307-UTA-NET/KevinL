namespace DemoApp.ConApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Uri uri = new Uri("http:localhost:7266");
            IO io = new IO(uri);
            await io.BeginAsync();
        }
    }
}
