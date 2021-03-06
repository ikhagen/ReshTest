﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ReshTest.Models;
using ReshTest.Services;
using System.Web.Http.Cors;

namespace ReshTest.Controllers
{
    //usikker på om dette er riktig måte å gjøre det på 
    [EnableCors(origins: "http://reshclient.azurewebsites.net", headers: "*", methods: "*")]
    public class StudentController : ApiController
    {

        private StudentRepository studentRepository; 

        public StudentController()
        {
            this.studentRepository = new StudentRepository();
        }

        public Student[] Get()
        {
            return this.studentRepository.GetAllStudents(); 
        }
    }
}
