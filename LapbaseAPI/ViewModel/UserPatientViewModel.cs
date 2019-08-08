using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LapbaseAPI.ViewModel
{
    public class UserPatientViewModel
    {
            public string UserId { get; set; }
            public string OrganizationCode { get; set; }
            public string PatientID { get; set; } 
            public bool IsSuccess { get; set; }
    }
}