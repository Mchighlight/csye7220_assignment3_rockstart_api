using System.IO;
using System;

namespace rockstar_api
{
    public class Music {

        public string Stronger { get; set; }
        public string DayAndNight { get; set; }
        public string BonitaApplebum { get; set; }

        public Music(){
            if( File.Exists("stronger.txt") ){
                Stronger = File.ReadAllText("stronger.txt");
            }
            else{
                Stronger = "No Stronger Lyrics";
            }

            if( File.Exists("day_and_night.txt") ){
                DayAndNight = File.ReadAllText("day_and_night.txt");
            }
            else{
                DayAndNight = "No DayAndNight Lyrics";
            }

            if( File.Exists("bonita_applebum.txt") ){
                BonitaApplebum = File.ReadAllText("bonita_applebum.txt");
            }
            else{
                BonitaApplebum = "No BonitaApplebum Lyrics";
            }
        }
    }
}
