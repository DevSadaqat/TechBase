import { Component, OnInit } from '@angular/core';
import {PatientService} from '../services/patient.service';
import {Patient} from '../models/Patient';

@Component({
  selector: 'app-demographic',
  templateUrl: './demographic.component.html',
  styleUrls: ['./demographic.component.css']
})
export class DemographicComponent implements OnInit {

  constructor(private pat_Serv: PatientService ) { }

  ngOnInit() {
  }

  
}
