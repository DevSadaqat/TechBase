import { Component, OnInit } from '@angular/core';
import {PatientService} from '../services/patient.service';
import {Patient} from '../models/Patient';
import {Authorization} from '../models/Authorization';
@Component({
  selector: 'app-demographic',
  templateUrl: './demographic.component.html',
  styleUrls: ['./demographic.component.css']
})
export class DemographicComponent implements OnInit {
  authori: Authorization[];
  patient: Patient[];
  constructor(private pat_Serv: PatientService ) { }

  ngOnInit() {
     return this.pat_Serv.getPatientById("10706","1").subscribe(data =>
      {
        window.alert(17)
        
        this.patient = data
       console.log(this.patient)
      });
                
  }
 
}
