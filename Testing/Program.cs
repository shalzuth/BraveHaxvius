using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BraveHaxvius;
using BraveHaxvius.Data;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new Facebook();
            fb.Login("email@gmail.com", "password");
            if (fb.TwoFactorAuth)
                fb.FinishTwoFactorAuth("1234 5678");
            fb.AllowFFBE();
            var b = new BraveExvius
            {
                FacebookUserId = fb.Id,
                FacebookToken = fb.AccessToken,
            };
            b.Login();
            b.DoMission(Mission.AirshipDeck, false, null, null, null, 0);
            b.DoMission(Mission.AirshipDeck);
        }
    }
}
