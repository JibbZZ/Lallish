namespace Videotek

{
    using System;
    using System.Drawing;
    using Console = Colorful.Console;
    using System.Threading;

    class MainMenu
    {

        public static void Menu()
        {
            Database Data = new Database();
            
            for (; ; )
            {
                Console.Clear();
                WriteLogo();
                Say("1", "List of movies");
                Say("2", "Rent a movie");
                Say("0", "Quit");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Data.ShowMovies();
                }
                else if (option == "2")
                {
                    //Hyr film
                }
                else if (option == "0")
                {
                    //quit
                }
                else
                {
                    Console.WriteLine("Error! Please choose a valid option!");
                    Thread.Sleep(1500);
                }
            }
        }

        public static void Say(string prefix, string message)
        {
            Console.Write("[");
            Console.Write(prefix, Color.DarkViolet);
            Console.WriteLine("] " + message);
        }

        public static void WriteLogo()
        {

            string logo = @" __     ___      
 \ \   / (_) __| | ___  ___ | |_ ___| | __
  \ \ / /| |/ _` |/ _ \/ _ \| __/ _ \ |/ /
   \ V / | | (_| |  __/ (_) | ||  __/   < 
    \_/  |_|\__,_|\___|\___/ \__\___|_|\_\
                                          
";
            Console.WriteLine(logo, Color.DarkViolet);

        }


    }






}