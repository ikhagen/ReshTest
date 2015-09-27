using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReshTest.Models;
using ReshTest.ServiceReference1;

namespace ReshTest.Services
{
    public class StudentRepository
    {
        public Student[] GetAllStudents()
        {
            return new Student[]
            {
                new Student
                {
                    ID = 1,
                    FirstName = "Draco",
                    LastName = "Malfoy",
                    House = "Slytherin"
                },
                new Student
                {
                    ID = 2,
                    FirstName = "Roonil",
                    LastName = "Wazlib",
                    House = "Gryffindor"
                }
            };
        } 
        
       public ReshUnit getUnitById()
        {

            ReshServiceClient client = new ReshServiceClient();
            ReshUnit name = client.GetReshUnit(100320, true, false, DateTime.Today); 

            // Use the 'client' variable to call operations on the service.

            // Always close the client.
            client.Close();
            return name;
        }       
    }
}