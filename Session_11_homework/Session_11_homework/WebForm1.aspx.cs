using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Session_11_homework
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Assignment 1
            if (!IsPostBack)
            {
                var numbers = Enumerable.Range(0, 9);

                var divisibleByTwo = numbers.Where(num => num % 2 == 0);

                string result = "The numbers which produce the remainder 0 after divided by 2 are: <br/>";

                result += string.Join(" ", divisibleByTwo);

                countResult.Text = result;
            }

            // Assignment 2
            if (!IsPostBack)
            {
                List<int> numbers = new List<int> { 1, 2, -4, 0, 11, 9, -5, -12, 18, 19 };

                var positiveNumbers = from num in numbers
                                      where num > 0 && num <= 20
                                      select num;

                posNumResult.Text = "Positive numbers within the range of 1 to 20 are: <br/>";
                posNumResult.Text += string.Join(" ", positiveNumbers);
            }

            // Assignment 3
            if (!IsPostBack)
            {
                string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

                char startingChar = 'A'; 
                char endingChar = 'M'; 

                var result = cities.FirstOrDefault(city => city.StartsWith(startingChar.ToString()) && city.EndsWith(endingChar.ToString()));

                cityListResults.Text = result != null ? $"The city starting with {startingChar} and ending with {endingChar} is : {result}" : "No city found with specified starting and ending characters.";
            }

            // Assignment 4
            if (!IsPostBack)
            {
                int[] numbers = { 9, 8, 6, 5 };

                var squares = from num in numbers
                              select new { Number = num, SqrNo = num * num };

                foreach (var square in squares)
                {
                    arraySquaredResult.Text += $"{{ Number = {square.Number}, SqrNo = {square.SqrNo} }} <br/>";
                }
            }

            // Assignment 5
            var movies = new[]
            {
                new { MovieID = 1, MovieName = "Inception", MovieActor = "Leonardo DiCaprio", MovieActress = "Ellen Page" },
                new { MovieID = 2, MovieName = "The Shawshank Redemption", MovieActor = "Tim Robbins", MovieActress = "None" },
                new { MovieID = 3, MovieName = "The Godfather", MovieActor = "Marlon Brando", MovieActress = "Diane Keaton" }
            };

            var xmlDocument = new XDocument(
                new XElement("Movies",
                    from movie in movies
                    select new XElement("Movie",
                        new XAttribute("MovieID", movie.MovieID),
                        new XElement("MovieName", movie.MovieName),
                        new XElement("MovieActor", movie.MovieActor),
                        new XElement("MovieActress", movie.MovieActress)
                    )
                )
            );

            xmlDocument.Save("movies.xml");

            Console.WriteLine("Movies information saved to movies.xml");

            //if (!IsPostBack)
            //{
            //    XDocument doc = XDocument.Load(Server.MapPath("movies.xml"));

            //    var movies = from movie in doc.Descendants("Movie")
            //                 select new
            //                 {
            //                     MovieName = (string)movie.Element("MovieName"),
            //                     MovieActor = (string)movie.Element("MovieActor"),
            //                     MovieActress = (string)movie.Element("MovieActress")
            //                 };

            //    foreach (var movie in movies)
            //    {
            //        lstMovies.Items.Add($"{movie.MovieName} - Actor: {movie.MovieActor}, Actress: {movie.MovieActress}");
            //    }
            //}

        }
    }
}