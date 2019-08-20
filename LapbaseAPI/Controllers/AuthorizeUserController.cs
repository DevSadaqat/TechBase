using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using LapbaseAPI.ViewModel;
using System.Net.Http;
using System.Web.Http;
using LapbaseEntityFramework.Repositories;
using LapbaseBOL;
using System.Web.Http.Cors;

namespace LapbaseAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class AuthorizeUserController : ApiController
    {
        private readonly IUserRepository userRepository = new UserRepository();        
        
        [Route("api/AuthorizeUser/AuthorizeUser")]
        [HttpGet]
        public IHttpActionResult AuthorizeUser(String username)
        {
            var obj = userRepository.GetUserByID(username);

            if (obj != null)
            {
                UserPatientViewModel userPatientViewModel = new UserPatientViewModel();
                userPatientViewModel.UserId = obj.ID.ToString();
                userPatientViewModel.PatientID = obj.PatientID.ToString();
                userPatientViewModel.OrganizationCode = obj.OrganizationCode.ToString();
                userPatientViewModel.IsSuccess = true;
                return Ok(userPatientViewModel);                
            }
            else
            {
                UserPatientViewModel userPatientViewModel = new UserPatientViewModel();
                userPatientViewModel.IsSuccess = false;              
                return Ok(userPatientViewModel);
            }        
        }

    }
}

