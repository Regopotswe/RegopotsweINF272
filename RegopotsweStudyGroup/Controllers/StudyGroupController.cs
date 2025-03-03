using RegopotsweStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace RegopotsweStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {
            // Create a list to store study group members
            List<StudyGroupMembers> Members = new List<StudyGroupMembers>
            {
                new StudyGroupMembers
                {
                    StudentNumber = "u24736661", 
                    Name = "Regopotswe",
                    Surname = "Moholane", 
                    EmailAddress = "u24736661@tuks.co.za" 
                },
                new StudyGroupMembers
                {
                    StudentNumber = "u24735558",
                    Name = "Palesa",
                    Surname = "Adams",
                    EmailAddress = "u24735558@tuks.co.za"
                },
                new StudyGroupMembers
                {
                    StudentNumber = "u34567890",
                    Name = "Odirile",
                    Surname = "Mmekoa",
                    EmailAddress = "u34567890@tuks.co.za"
                },
                new StudyGroupMembers
                {
                    StudentNumber = "u45678901",
                    Name = "Gontse",
                    Surname = "Rashopola",
                    EmailAddress = "45678901@tuks.co.za"
                },
                new StudyGroupMembers
                {
                    StudentNumber = "u56789012",
                    Name = "Aaron",
                    Surname = "Appleton",
                    EmailAddress = "u56789012@tuks.co.za"
                }
            };

            // showing what should be displayed to the user
            return View(Members);
        }
    }
}