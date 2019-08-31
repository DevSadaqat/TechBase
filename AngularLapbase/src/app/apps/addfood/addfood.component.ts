import { Component, AfterViewInit } from '@angular/core';
import { FoodService } from '../../services/food.service';
import {Food} from '../../models/Food';
import { NgForm, FormBuilder, Validators } from '@angular/forms';
import { DataService } from '../../services/data.service';
import { Observable } from 'rxjs';

@Component({
  templateUrl: './addfood.component.html'
})

export class AddfoodComponent implements AfterViewInit {
  FoodForm: any;
  patID: string;
  orgCode: string;
  food: Food = {
   
    Quantity: "",
    FoodType: "",
    PatientID: "",
    OrganizationCode: ""
    }
  constructor(private formbuilder: FormBuilder, 
    private foodService: FoodService,
    public dataService: DataService) { }

  
    ngAfterViewInit(){
      this.FoodForm = this.formbuilder.group({
        FoodType: ['', [Validators.required]],
        Quantity: ['', [Validators.required]],    
      });
      this.patID  = localStorage.getItem("patientID");
      
      this.orgCode = localStorage.getItem("organizationCode");
      //this.patID = this.dataService.getPatientID();
      //this.orgCode =this.dataService.getOrganizationCode();
     }
     foodUser(event){
     // window.alert(97);
     // this.FoodForm=FoodForm;
      event.preventDefault()
      const target = event.target
     
      this.food.FoodType =target.querySelector('#FoodType').value
      this.food.Quantity = target.querySelector('#Quantity').value
    // this.food = this.FoodForm.value;
    console.log(this.food);
     // window.alert(97);
      this.CreateFood(this.food);
    }
    CreateFood(food: Food) {  
      //if (this.foodIdUpdate == null) {  
        food.PatientID = this.patID;
        food.OrganizationCode = this.orgCode;
        console.log(food);
       // window.alert(86);
        this.foodService.createFood(food).subscribe(  
          () => {  
           // window.alert(87);
           // this.dataSaved = true;
           // this.massage = 'Record saved Successfully';  
          //  this.getAllFoods();  
          //  this.foodIdUpdate = null;  
          //  this.FoodForm.reset();  
          }  
        );  
    }

}
