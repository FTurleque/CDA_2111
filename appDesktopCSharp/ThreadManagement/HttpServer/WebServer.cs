using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpServer
{
    public class WebServer
    {
        public Boolean Running { get; private set; }
        HttpListener server;

        public async void Start()
        {
            using (server = new HttpListener())
            {
                server.Prefixes.Add("http://localhost:8000/");
                // server.Prefixes.Add(Environment.MachineName);
                server.Start();
                Running = true;

                while(Running)
                {
                    var context = await server.GetContextAsync();
                    Thread thread1 = new Thread(OnRequest);
                    thread1.Start(context);
                }
            };
        }

        public void Stop()
        {
            Running = false;
        }

        public void OnRequest(object? req)
        {
            if(req is HttpListenerContext ctx)
            {
                // string s = "<html>Bonjour !</html>";
                List<Car> cars = Car.GetCars();

                // Conversion en Json.
                string json = JsonSerializer.Serialize(cars);

                // Conversion Json en Objet C#
                // List<Car>? newCars = JsonSerializer.Deserialize<List<Car>>(json);

                byte[] res = Encoding.UTF8.GetBytes(json.ToCharArray());

                ctx.Response.Close(res, true);
            }
        }
    }
}
