import { Component, AfterViewInit } from '@angular/core';
import {PatientService} from '../../services/patient.service';
import {Patient} from '../../models/Patient';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-demographic',
  templateUrl: './demographic.component.html',
  styleUrls: ['./demographic.component.scss']
})
export class DemographicComponent implements AfterViewInit {
  patID: string;
  orgCode: string;
  patient: Patient = {
    ID: "",
    OrganizationCode: "",
    Title: "",
    Surname:"",
    FirstName: "",
    BirthDate: "",
    Gender:  "",
    Height:  "",
    PhoneNumber:  "",
    Mobile:  "",
    ContactEmail:  "",
    Street:  "",
    Suburb:  "",
    City:  "",
    State:  "",
    PinCode:  "",
    Country:  "",
    Insurance: "",
    InsuranceEmployer:  "",
    InusuranceNumber:  "",
    MedicareNumber:  ""
  };
constructor(private pat_Serv: PatientService) { }
ngAfterViewInit() {

  this.patID  = localStorage.getItem("patientID");
  this.orgCode = localStorage.getItem("organizationCode");

   return this.pat_Serv.getPatientById(this.patID,this.orgCode).subscribe(data =>
    {        
      //window.alert(1)
      this.patient = data
      //localStorage.setItem("FirstName", this.patient.F);
      localStorage.setItem("Height", data.Height);
     //console.log(this.patient)
    }); 
 }
}