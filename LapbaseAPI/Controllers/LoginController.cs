using System;
using System.Collections.Generic;
using LapbaseAPI.ViewModel;
using EF;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using System.Web.Http.Cors;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Net.Http.Formatting;

namespace LapbaseAPI.Controllers
{
    [EnableCors(origins:"http://localhost:4200", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        private bool authenticate = false;
        private string username = "";
        private Lapbase db;
        [HttpPost]
        public IHttpActionResult Login(LoginViewModel model)
        //   public bool Login(LoginViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var isValidUser = AuthenticateUser(model.UserName, model.Password);
           // var isValidUser = AuthenticateUser("TechInnovators","TechInnovator17");
            if (!isValidUser)
            {
               ModelState.AddModelError("", "The user name or password provided is incorrect.");
               return Ok(ModelState);
            }
            else
            {
                authenticate = true;
                username = model.UserName;
                return Ok(model.UserName);
               // return base.Content(HttpStatusCode.OK, new {Value = "ApiREturned" }, new JsonMediaTypeFormatter(), "text/plain");
               // return base.Content(HttpStatusCode.OK, new { Value = obj.ID.ToString() }, new JsonMediaTypeFormatter(), "text/plain");

            }
        }
     /* [HttpPost]
        public IHttpActionResult AuthorizeUser()
        {
            if(authenticate)
            {
                db = new Lapbase();
               // var obj = db.Users.Where(a => a.ID.Equals(username)).FirstOrDefault();
               var obj = db.Users.Where(a => a.ID.Equals("TechInnovators")).FirstOrDefault();
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
                else {
                    UserPatientViewModel userPatientViewModel = new UserPatientViewModel();
                    userPatientViewModel.IsSuccess = false;
                            //ModelState.AddModelError("", "Not a patient");
                    return Ok(userPatientViewModel);    
                }
                  //  FormsAuthentication.SetAuthCookie(model.UserName, false);
                    // return RedirectToAction("Welcome", "Home");
            }
           return Ok();
        }
      */
        #region public bool AuthenticateUser(string username, string password)
        private bool AuthenticateUser(string username, string password)
        {
            string domainName = System.Configuration.ConfigurationManager.AppSettings["Domain Name"];

            string domainAndUsername = string.Format(@"{0}\{1}", domainName, username);

            string ldapPath = string.Format("LDAP://" + domainName);

            bool authentic = false;

            bool userMustChangePassword = false;

            bool userAccountIsExpired = false;

            try
            {

                DirectoryEntry entry = new DirectoryEntry(ldapPath, domainAndUsername, password);

                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, domainName))

                {

                    UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, username);

                    if (userPrincipal.AccountExpirationDate.HasValue)

                        if (userPrincipal.AccountExpirationDate < DateTime.Now)

                            userAccountIsExpired = true;

                    if (!userPrincipal.LastPasswordSet.HasValue)

                        if (!userPrincipal.PasswordNeverExpires)

                            userMustChangePassword = true;

                }
                // now authenitcate the user
                object obj = entry.NativeObject;
                authentic = true;
            }
            catch (Exception ex)
            {
                // throw ex;
            }

            return authentic;

        }

        #endregion
    }
}
