import { Component, OnInit } from '@angular/core';
import {PatientService} from '../../services/patient.service';
import {Patient} from '../../models/Patient';
import { DataService } from '../../services/data.service';
import { NgForm, FormBuilder, Validators } from '@angular/forms';

import { Observable } from 'rxjs';
@Component({
  selector: 'app-demographicdetails',
  templateUrl: './demographicdetails.component.html',

})
export class DemographicdetailsComponent implements OnInit {

  patID: string;
  orgCode: string;
  patient: Patient[] ;

  constructor(private pat_Serv: PatientService,
    public dataService: DataService) { }

  ngOnInit() {
   // window.alert(2)

    /*this.patID  = localStorage.getItem("patientID");
    this.orgCode = localStorage.getItem("organizationCode");
    this.patient = this.pat_Serv.getPatientById(this.patID,this.orgCode);
   // this.patient = this.pat_Serv.getPatientById("10706","1");
   window.alert(10);
   console.log(this.patient)
    */
   this.patID = this.dataService.getPatientID();
   this.orgCode = this.dataService.getOrganizationCode();
   //this.patID  = localStorage.getItem("patientID");
   //this.orgCode = localStorage.getItem("organizationCode");

   return this.pat_Serv.getPatientById(this.patID,this.orgCode).subscribe(data =>
    {
      window.alert(1)
      console.log(data)
      window.alert(1)
      //this.patient = data

     //console.log(this.patient)
    });
   /*return this.pat_Serv.getPatientById("10706","1").subscribe(data =>
      {
        window.alert(1)
        this.patient = data
       console.log(this.patient)
      });*/
     }


  }
