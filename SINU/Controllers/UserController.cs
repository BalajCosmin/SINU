using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SINU.UserModel;
using System.Data;
using System.Data.SqlClient;

namespace SINU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        [HttpGet]
        //se poate face si cu EntityFramework in loc de proceduri SQL
        public JsonResult Get()
        {
            string query = @" select UserID,FirstName,LastName,AccountName,Password,Email from
  dbo.Users";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("SINUAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();

                using (SqlCommand myComand = new SqlCommand(query, myCon))
                {
                    myReader = myComand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }




        [HttpPost]
        public JsonResult Post(User user)
        {
            string query = @" INSERT INTO dbo.Users values (@UserName,@Password,@Email)";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("SINUAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();

                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {

                    myCommand.Parameters.AddWithValue("@UserName", user.UserName);
                    myCommand.Parameters.AddWithValue("@Password", user.UserPassWord);
                    myCommand.Parameters.AddWithValue("@Email", user.UserEmail);



                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }



        [HttpPut]
        public JsonResult Put(User user)
        {
            string query = @" update dbo.Users set FirstName=@FirstName 
                              where UserID=@UserId";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("SINUAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();

                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@UserId", user.UserId);
                    myCommand.Parameters.AddWithValue("@UserName", user.UserName);
                    myCommand.Parameters.AddWithValue("@Password", user.UserPassWord);
                    myCommand.Parameters.AddWithValue("@Email", user.UserEmail);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }


        [HttpDelete]
        public JsonResult Delete(int id)
        {
            string query = @" delete from dbo.Users 
                              where UserID=@UserId";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("SINUAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();

                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@UserId", id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }

    }
}
