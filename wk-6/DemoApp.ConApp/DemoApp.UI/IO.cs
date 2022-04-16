using System.Net.Http.Json;
using System.Net.Mime;
using DemoApp.ConApp.DTOs;

namespace DemoApp.UI
{
    public class IO
    {
        //Fields
        private readonly Uri uri;

        //Constructors
        public IO (Uri uri)
        {
            this.uri = uri;
        }

        //Methods
        public async Task BeginAsync()
        {
            Console.WriteLine("ConsoleApp Running...");
            bool loop = true;

            do
            {
                int choice = MainMenu();
                switch(choice)
                {
                    case -1:
                        Console.WriteLine("Bad input, please try again");
                        Console.WriteLine("Press an keyto continue");
                        Console.WriteLine();
                        break;
                    case 0: loop = false; break;
                    case 1:
                        await DisplayAllDevicesAsync();
                        break;
                }
            } while (loop == true);
        }

        private int MainMenu()
        {
            int choice = -1;
            Console.WriteLine("Please select the option of your choice");
            Console.WriteLine("[0] - Exit");
            Console.WriteLine("[1] - Get All Devices Information");
            Console.WriteLine("[2] - Get A Devices Information");
            string? input = Console.ReadLine();
            //if( int TryParse(input, out choice))
            //        { return choice; }
            //else
            //{
            //    choice = -1;
            //    return choice;
            //}
            if (!int.TryParse(input, out choice))
                    { choice = -1; }
            return choice;
        }

        private async Task DisplayAllDevicesAsync()
        {
            string address = uri.ToString();
            address += "Devices";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri.ToString() + "Devices");
            request.Headers.Accept.Add(new(MediaTypeNames.Application.Json));

            HttpResponseMessage response;

            //try
            //{
            //    response = await httpClient.SendAsync(request);
            //    //string result = await response.Content.ReadAsStringAsync();
            //    //Console.WriteLine(response.Content.ToString());
            //    //Console.WriteLine("Please any key to continue");
            //    //Console.WriteLine();
            //}
            //catch(HttpRequestExxception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Please any key to continue");
            //    Console.WriteLine();
            //}

            var devices = List<DeviceDTO>;
            using (HttpResponseMessage response = await HttpClient.SendAsync())
            {
                response.EnsureSuccessStatusCode();

                if (response.Content.Headers.ContentType?.MediaType != MediaTypeNames.Application.Json)
                {
                    throw new ArrayTypeMismatchException();
                }

                var devices = await response.Content.ReadFromJsonAsync<List<DeviceDTO>>();
            }

                

            if (devices != null)
            {
                Console.WriteLine("Devices :");
                foreach (var device in devices)
                {
                    Console.WriteLine("Device Name: " + device.Name);
                }
                Console.WriteLine("\nPress any key to continue");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No device found");
                
            }

            Console.WriteLine("\nPress any key to continue");
            Console.WriteLine();
            Console.Clear();
        }
    }
}