import { Component, AfterViewInit } from '@angular/core';
import { WeightService } from '../../services/weight.service';
import {Weight} from '../../models/Weight';
import { NgForm, FormBuilder, Validators } from '@angular/forms';
import { DataService } from '../../services/data.service';
import { Observable } from 'rxjs';

@Component({

  selector: 'app-weight',
  templateUrl: './weight.component.html',
  styleUrls: ['./weight.component.css']
})
export class WeightComponent implements AfterViewInit{
WeightForm: any;
  patID: string;
  orgCode: string;
  
  allWeights: Observable<Weight[]>;
  weight: Weight = {
    WeightValue: "",
    PatientID: "",
    OrganizationCode: "",
    BMI: ""
  }
  latestWeight: Observable<Weight>;
  
  constructor(private formbuilder: FormBuilder, 
    private weightService: WeightService,) { }

  ngAfterViewInit() {
    this.WeightForm = this.formbuilder.group({
      WeightValue: ['', [Validators.required]]
       
    });
    this.patID  = localStorage.getItem("patientID");
    
    this.orgCode = localStorage.getItem("organizationCode");
    this.getAllWeights();
  }
  weightUser(event){
    // window.alert(97);
    
     event.preventDefault()
     const target = event.target
    
     this.weight.WeightValue =target.querySelector('#WeightValue').value
     
   
   
    // window.alert(97);
     this.CreateWeight(this.weight);
     
   }
   CreateWeight(weight: Weight) {  
     //if (this.foodIdUpdate == null) {  
       weight.PatientID = this.patID;
       weight.OrganizationCode = this.orgCode;
       console.log(weight);
      // window.alert(86);
       this.weightService.createWeight(weight).subscribe(  
         () => {  
          this.getAllWeights();    
         }  
       ); 
       
   }
   getAllWeights(){
    this.allWeights = this.weightService.getWeight(this.patID,this.orgCode);
  }
  getLatestWeight()
  {
    this.latestWeight = this.weightService.getLatestWeight(this.patID,this.orgCode);
  }

}

