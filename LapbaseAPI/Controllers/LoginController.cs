using System;
using System.Collections.Generic;
using LapbaseAPI.ViewModel;
using EntityFramework;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using System.Web.Http.Cors;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace LapbaseAPI.Controllers
{
   // [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        private bool authenticate = false;
        private string username = "";
        private Lapbase db;
        [HttpGet]
        public IHttpActionResult Login(LoginViewModel model)
                //public int Login(LoginViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //  var isValidUser = AuthenticateUser(model.UserName, model.Password);
            var isValidUser = AuthenticateUser("TechInnovators","TechInnovator17");
            if (!isValidUser)
            {
                ModelState.AddModelError("", "The user name or password provided is incorrect.");
                return Ok(ModelState);
            }
            else
            {
                authenticate = true;
                username = model.UserName;
                return Ok();
               /* using (LB db = new LB())
                {
                    var obj = db.Users.Where(a => a.ID.Equals(model.UserName)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.ID.ToString();
                        Session["OrganizationCode"] = obj.OrganizationCode.ToString();
                        Session["PatientID"] = obj.PatientID.ToString();
                    }
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    // return RedirectToAction("Welcome", "Home");+
                    return RedirectToAction("Index", "Home");

                }
                */
            }
        }

        private IHttpActionResult AuthorizeUser()
        {
            if(authenticate)
            {
                db = new Lapbase();
                
                    var obj = db.Users.Where(a => a.ID.Equals(username)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.ID.ToString();
                        Session["OrganizationCode"] = obj.OrganizationCode.ToString();
                        Session["PatientID"] = obj.PatientID.ToString();
                    }
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    // return RedirectToAction("Welcome", "Home");+
                   

                

            }
            return Ok();
        }
      
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
