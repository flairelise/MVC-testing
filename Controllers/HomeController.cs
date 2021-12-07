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

        public IActionResult MovieList()
        {
            FetchData();
            return View(movies);
        }
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
                com.CommandText = "SELECT TOP (1000) Movie_Name, Streamable, Release_Date, Duration FROM Movie ORDER BY Movie_Name";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    movies.Add(new Movies()
                    {
                        Movie_Name = dr["Movie_Name"].ToString()
                    ,
                        Streamable = dr["Streamable"].ToString()
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
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        /////////////
        ///

    }

}

