using System;
using System.Collections.Generic;
using LapbaseAPI.ViewModel;
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
using System.Configuration;

namespace LapbaseAPI.Controllers
{
    [EnableCors(origins:"http://localhost:4200", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        private bool authenticate = false;
        private string username = "";
       
        
        [HttpPost]
        public IHttpActionResult Login(LoginViewModel model)
       
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
               

            }
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
