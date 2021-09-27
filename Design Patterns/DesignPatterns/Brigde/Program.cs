using Brigde.Plataforms;
using Brigde.Transmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brigde
{
    class Program
    {

        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");
            
            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }


        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtitles();
            live.Comments();
            live.Result();
        }



        static void Main(string[] args)
        {

            StartLiveAdvanced(new YouTube());
            StartLive(new Facebook());
            StartLive(new TwitchTV());

            Console.ReadLine();
        }
    }
}
