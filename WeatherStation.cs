using System;

namespace WeatherStation
{
    public delegate string TempState(double Temperature);
    public delegate string WindState(double Wind);
    class WeatherStation
    {
         event TempState tempStat;
         event WindState windStat;
        public WeatherStation()
        {
            this.tempStat += new TempState(this.TemperatureStatus);
            this.windStat += new WindState(this.WindSpeed);

        }
        public string TemperatureStatus(double temperature) {
            string TempStatus = "";

            if (temperature > 40)
            {

                TempStatus = "It's Hot ";
            }
            else if (temperature < 40)
            {

                TempStatus = "It's Cold ";
            }
            return TempStatus;
        }
        public string WindSpeed(double speed)
        {
            string speedStatus = "";

            if (speed > 40)
            {

                speedStatus = "Windy ";
            }
            else if (speed < 40)
            {

                speedStatus = "Sheltered";
            }
            return speedStatus;
        }

        class Satellite
        {
            Random rnd = new Random();
            public double temperature()
            {

                double temp = rnd.Next(1, 100);
                return temp;
            }
             public double windspeed()
            {
                double windiness = rnd.Next(1, 100);
                return windiness;
            }
        }

        static void Main(string[] args)
        {
            bool StopReadingStatus = true;
            string result = "";
            string result1 = "";
            string Continue = "";
            while (StopReadingStatus) {

                WeatherStation weatherStats = new WeatherStation();
                Satellite DataGather = new Satellite();
                result = weatherStats.TemperatureStatus(DataGather.temperature());
                result1 = weatherStats.WindSpeed(DataGather.windspeed());
                Console.WriteLine("Temperature " + result + " WindStatus " + result1 );
                
                Continue = Console.ReadLine();
                if (Continue == "STOP") {

                    StopReadingStatus = false;
                } else {

                    StopReadingStatus = true;
                }
            }

          
        }
    }
}