using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusinessDevProject.Models;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using WebMatrix.Data;
using System.Configuration;
using System.Data;

namespace BusinessDevProject.Controllers
{
    public class HomeController : Controller
    {
        SqlCommand Command = new SqlCommand();
        SqlDataReader DataReader;
        SqlConnection Connection = new SqlConnection();
        List<Movies> listMovies = new List<Movies>();
        List<Details> movieDetails = new List<Details>();
        

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            Connection.ConnectionString = BusinessDevProject.Properties.Resources.ConnectionString;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login(string userName, string passWord)
        {
            if ((!String.IsNullOrEmpty(userName)) && (!String.IsNullOrEmpty(passWord)))
            {
               
                try
                {
                    DataTable dt = new DataTable();
                    new Login() { Username = userName, Password = passWord };
                    Connection.Open();
                    Command.Connection = Connection; 
                    string sql = "SELECT User_ID FROM Users WHERE Username ='"+ userName + "' AND Password = '"+ passWord +"'";
                    
                    SqlDataAdapter da = new SqlDataAdapter(sql, Connection);
                    
                  
                    
                    
                }
                catch (Exception ex)
                {
                    Connection.Close();
                    throw ex;
                   
                }
            }
            else

            {
                Connection.Close();
            }

            Connection.Close();
            return View();
        }

    

     // removed MovieList(); because it was obselete once I added Task<IActionResult> MovieList, which you can find below vvvv

        public async Task<IActionResult> MovieList(string searchString) //what controls the magic behind the Movies view
        {
           //note that it is async, but I don't use await...don't be like me and ignore stuff like this, but I did it because...ig I'm a rebel (just didn't wanna spend more time debugging)

            if (!String.IsNullOrEmpty(searchString))
            {
                if (listMovies.Count > 0)
                {
                    listMovies.Clear();
                }
                try
                {
                    Connection.Open();
                    Command.Connection = Connection; //prepare for the longest SQL statements you'll probably ever see, yay!
                    Command.CommandText = "SELECT TOP (1000) Movie.Movie_ID, Movie.Movie_Name, Director.Name, Movie.Streamable, Genre.Genre_Name, FORMAT(Movie.Release_Date, 'MM/dd/yyyy') AS Release_Date, Movie.Duration FROM Movie INNER JOIN Genre ON Movie.Movie_ID = Genre.Movie_ID INNER JOIN Director ON Movie.Director_ID = Director.Director_ID WHERE Movie.Movie_Name LIKE '%" + searchString  + "%' ORDER BY Movie.Movie_Name";
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        listMovies.Add(new Movies()
                        {
                            Movie_ID = DataReader["Movie_ID"].ToString()
                        ,
                            Movie_Name = DataReader["Movie_Name"].ToString()
                        ,
                            Director_Name = DataReader["Name"].ToString()
                        ,
                            Streamable = DataReader["Streamable"].ToString()
                        ,
                            Genre = DataReader["Genre_Name"].ToString() //because we pull genre from the genre table, we have to refer to every column by its table in the statement above
                        ,
                            Release_Date = DataReader["Release_Date"].ToString()
                        ,
                            Duration = DataReader["Duration"].ToString()

                        });
                    }
                    Connection.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return View(listMovies);
        }

        public async Task<IActionResult> Details(int id)
        {
                try
                {
                    var urlid = Url.ActionContext.RouteData.Values["id"];
                    Connection.Open();
                    Command.Connection = Connection; //prepare for the longest SQL statements you'll probably ever see, yay!
                    Command.CommandText = "SELECT Movie.Movie_ID, Movie.Movie_Name, Director.Name, Movie.Streamable, Genre.Genre_Name, FORMAT(Movie.Release_Date, 'MM/dd/yyyy') AS Release_Date, Movie.Duration FROM Movie INNER JOIN Genre ON Movie.Movie_ID = Genre.Movie_ID INNER JOIN Director ON Movie.Director_ID = Director.Director_ID WHERE Movie.Movie_ID = '" + urlid + "'";
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        movieDetails.Add(new Details()
                        {
                            Movie_ID = DataReader["Movie_ID"].ToString()
                        ,
                            Movie_Name = DataReader["Movie_Name"].ToString()
                        ,
                            Director_Name = DataReader["Name"].ToString()
                        ,
                            Streamable = DataReader["Streamable"].ToString()
                        ,
                            Genre = DataReader["Genre_Name"].ToString() //because we pull genre from the genre table, we have to refer to every column by its table in the statement above
                        ,
                            Release_Date = DataReader["Release_Date"].ToString()
                        ,
                            Duration = DataReader["Duration"].ToString()

                        });
                    }
                    Connection.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            

            return View(movieDetails);

        }

   
        
        //error page settings below -------------------------


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
        

    }

}

