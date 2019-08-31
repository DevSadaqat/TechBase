import { Component, OnInit } from '@angular/core';
import {PatientService} from '../services/patient.service';
import {Patient} from '../models/Patient';
import {Authorization} from '../models/Authorization';
import { DataService } from '../services/data.service';
import { PatternValidator } from '@angular/forms';

@Component({
  selector: 'app-demographic',
  templateUrl: './demographic.component.html',
  styleUrls: ['./demographic.component.css']
 
})
export class DemographicComponent implements OnInit {
  authori: Authorization ={
    UserId: "",
    OrganizationCode: "",
    PatientID: "",
    IsSuccess: false
  };
  patient: Patient[];
  patID: string;
  orgCode: string;
 
  constructor(private pat_Serv: PatientService,
    public dataService: DataService ) { }

  ngOnInit() {
    
     this.patID = this.dataService.getPatientID();
     this.orgCode = this.dataService.getOrganizationCode();

     return this.pat_Serv.getPatientById(this.patID,this.orgCode).subscribe(data =>
      {        
        window.alert(1)
        this.patient = data
       console.log(this.patient)
      });
                
  }
  
 
}
