using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using LapbaseAPI.ViewModel;
using System.Net.Http;
using System.Web.Http;
using EF;

namespace LapbaseAPI.Controllers
{
    public class AuthorizeUserController : ApiController
    {
      //  private string username = "";
        private Lapbase db;
        [Route("api/AuthorizeUser/AuthorizeUser")]
        [HttpGet]
        public IHttpActionResult AuthorizeUser(String username)
        {

            db = new Lapbase();
            var obj = db.Users.Where(a => a.ID.Equals(username)).FirstOrDefault();
            //  var obj = db.Users.Where(a => a.ID.Equals("TechInnovators")).FirstOrDefault();
            if (obj != null)
            {
                UserPatientViewModel userPatientViewModel = new UserPatientViewModel();
                userPatientViewModel.UserId = obj.ID.ToString();
                userPatientViewModel.PatientID = obj.PatientID.ToString();
                userPatientViewModel.OrganizationCode = obj.OrganizationCode.ToString();
                userPatientViewModel.IsSuccess = true;
                return Ok(userPatientViewModel);
                //return base.Content(HttpStatusCode.OK, new { Value = obj.ID.ToString()}, new JsonMediaTypeFormatter(), "text/plain");
            }
            else
            {
                UserPatientViewModel userPatientViewModel = new UserPatientViewModel();
                userPatientViewModel.IsSuccess = false;
                //ModelState.AddModelError("", "Not a patient");
                return Ok(userPatientViewModel);
            }
            //  FormsAuthentication.SetAuthCookie(model.UserName, false);
            // return RedirectToAction("Welcome", "Home");


        }

    }
}

