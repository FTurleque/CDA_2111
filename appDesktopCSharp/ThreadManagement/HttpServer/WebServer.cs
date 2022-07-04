using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer
{
    public class WebServer
    {
        Boolean running;
        HttpListener server;

        public async void Start()
        {
            using (server = new HttpListener())
            {
                server.Prefixes.Add("http://localhost:8000/");
                // server.Prefixes.Add(Environment.MachineName);
                server.Start();
                running = true;

                while(running)
                {
                    var context = await server.GetContextAsync();
                    Thread thread1 = new Thread(OnRequest);
                    thread1.Start(context);
                }
            };
        }

        public void Stop()
        {
            running = false;
        }

        public void OnRequest(Object req)
        {
            if(req is HttpListenerContext ctx)
            {
                string s = "<html>Bonjour !</html>";
                byte[] res = Encoding.UTF8.GetBytes(s.ToCharArray());

                ctx.Response.Close(res, true);
            }
        }
    }
}
