import { Component, AfterViewInit } from '@angular/core';
import { FoodService } from '../../services/food.service';
import {Food} from '../../models/Food';
import { NgForm, FormBuilder, Validators } from '@angular/forms';

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
    private foodService: FoodService) { }

  
    ngAfterViewInit(){
      this.FoodForm = this.formbuilder.group({
        FoodType: ['', [Validators.required]],
        Quantity: ['', [Validators.required]],    
      });
      this.patID  = localStorage.getItem("patientID");
      
      this.orgCode = localStorage.getItem("organizationCode");
      
     }
     foodUser(event){

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
     
        food.PatientID = this.patID;
        food.OrganizationCode = this.orgCode;
        console.log(food);
       // window.alert(86);
        this.foodService.createFood(food).subscribe(  
          () => {  
         
          }  
        );  
    }

}
