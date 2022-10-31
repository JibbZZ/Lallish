namespace Videotek
{
    using Dapper;
    using MySqlConnector;
    using System;
    using System.Drawing;
    using Console = Colorful.Console;

    public class Videotek
    {

        public int id { get; set; }
        public string name { get; set; }
        public string eMail { get; set; }
        public int phoneNumber { get; set; }
        public string city { get; set; }
        public int postalCode { get; set; }
        public string title { get; set; }
        public int Year { get; set; }
        public int minutes { get; set; }
        public int serialNumber { get; set; }
        public int price { get; set; }
        public string director { get; set; }



        public override string ToString()
        {
            return $"{id} {name}";
        }

    }
    internal class Program
    {

        private static void Main(string[] args)
        {

            Console.Title = "Login";
            MainMenu.WriteLogo();
            Console.WriteLine("Welcome", Color.DarkViolet);
            Console.ReadKey(true);
            MainMenu.Menu();

            {
                
            }
        }
    }

}