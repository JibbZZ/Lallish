namespace Videotek
{
    using Dapper;
    using MySqlConnector;

    public class Database
    {
        public void ShowUsers()
        {

            using (var connection = new MySqlConnection("Server=localhost;Database=Videotek;Uid=root;"))
            {
                var users = connection.Query<Videotek>("SELECT id, name, eMail, phoneNumber, city, postalCode FROM Users;").ToList();
                foreach (Videotek u in users)
                {
                    Console.WriteLine(u.id + "  " + u.name + " " + u.eMail + " " + u.phoneNumber + " " + u.city + " " + u.postalCode);
                }
            }
        }
        public void ShowMovies()

        {
            using (var connection = new MySqlConnection("Server=localhost;Database=Videotek;Uid=root;"))
            {
                var movies = connection.Query<Videotek>("SELECT id, title, minutes, Year, serialNumber, director, price FROM Movies").ToList();
                foreach (Videotek m in movies)
                {
                    Console.WriteLine("ID: " + m.id + " " + "Titel: " + m.title + " " + "Year: " + m.Year + " " + "Serialnumber: " + m.serialNumber + " " + "Director: " + m.director + " " + "Year: " + m.Year);
                }
            }

        }
    }
}

