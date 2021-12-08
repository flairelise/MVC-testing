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

namespace BusinessDevProject.Controllers
{
    public class HomeController : Controller
    {
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        List<Movies> movies = new List<Movies>();
        

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            con.ConnectionString = BusinessDevProject.Properties.Resources.ConnectionString;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

       // public IActionResult MovieList()
       // {
         //   FetchData();
         //   return View(movies);
       // }
        private void FetchData()
        {
            if (movies.Count > 0)
            {
                movies.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT TOP (1000) Movie.Movie_Name, Movie.Streamable, Genre.Genre_Name, FORMAT(Movie.Release_Date, 'MM/dd/yyyy') AS Release_Date, Movie.Duration FROM Movie INNER JOIN Genre ON Movie.Movie_ID = Genre.Movie_ID ORDER BY Movie.Movie_Name";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    movies.Add(new Movies()
                    {
                        Movie_Name = dr["Movie_Name"].ToString()
                    ,
                        Streamable = dr["Streamable"].ToString()
                    ,
                        Genre = dr["Genre_Name"].ToString()
                    ,
                        Release_Date = dr["Release_Date"].ToString()
                    ,
                        Duration = dr["Duration"].ToString()
                    
                    });
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> MovieList(string searchString)
        {
           

            if (!String.IsNullOrEmpty(searchString))
            {
                if (movies.Count > 0)
                {
                    movies.Clear();
                }
                try
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "SELECT TOP (1000) Movie.Movie_Name, Movie.Streamable, Genre.Genre_Name, FORMAT(Movie.Release_Date, 'MM/dd/yyyy') AS Release_Date, Movie.Duration FROM Movie INNER JOIN Genre ON Movie.Movie_ID = Genre.Movie_ID WHERE Movie.Movie_Name LIKE '%" + searchString  + "%' ORDER BY Movie.Movie_Name";
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        movies.Add(new Movies()
                        {
                            Movie_Name = dr["Movie_Name"].ToString()
                        ,
                            Streamable = dr["Streamable"].ToString()
                        ,
                            Genre = dr["Genre_Name"].ToString()
                        ,
                            Release_Date = dr["Release_Date"].ToString()
                        ,
                            Duration = dr["Duration"].ToString()

                        });
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return View(movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        /////////////
        ///

    }

}

