import { Component, OnInit } from '@angular/core';
import { FoodService } from '../services/food.service';
import {Food} from '../models/Food';
import { NgForm, FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-food',
  templateUrl: './food.component.html',
  styles: []
})

export class FoodComponent implements OnInit {
 
 // Food: Food[];
  FoodForm: any;
  dataSaved = false;
  allFoods: Observable<Food[]>;
  patID: string;
  orgCode: string;
 // foodIdUpdate =null;
  food: Food = {
   
    Quantity: "",
    FoodType: "",
    PatientID: "",
    OrganizationCode: ""
    }
  

  constructor(private formbuilder: FormBuilder, 
    private foodService: FoodService,
    public dataService: DataService) { }

  ngOnInit() {
    this.FoodForm = this.formbuilder.group({
      FoodType: ['', [Validators.required]],
      Quantity: ['', [Validators.required]],    
    });
    this.patID = this.dataService.getPatientID();
    this.orgCode =this.dataService.getOrganizationCode();
    this.getAllFoods();
  }
  getAllFoods(){
    this.allFoods = this.foodService.getFood(this.patID,this.orgCode);
  }
  foodUser(event){
    window.alert(97);
   // this.FoodForm=FoodForm;
    event.preventDefault()
    const target = event.target
   
    this.food.FoodType =target.querySelector('#FoodType').value
    this.food.Quantity = target.querySelector('#Quantity').value
  // this.food = this.FoodForm.value;
  console.log(this.food);
    window.alert(97);
    this.CreateFood(this.food);
  }
 /* onFormSubmit() {   
    this.dataSaved = false;
    const food = this.FoodForm.value;  
    //const target = food.target;
    //food.FoodType = target.querySelector('#FoodType').value
    //food.Quantity = target.querySelector('#Quantity').value
    window.alert(11);
    console.log(food);
    this.CreateFood(food);
    window.alert(12); 
    console.log(food); 
    this.FoodForm.reset();  
  }  */
  /*updateFood(foodId: string) {  
    this.foodService.getFoodById(foodId).subscribe(food=> {  
     // this.massage = null;  
     
      this.foodIdUpdate = food.ID;

     this.FoodForm.controls['FoodType'].setValue(food.FoodType);
     this.FoodForm.controls['Quantity'].setValue(food.Quantity);
     
    });  
  
  }*/  
  CreateFood(food: Food) {  
    //if (this.foodIdUpdate == null) {  
      food.PatientID = this.patID;
      food.OrganizationCode = this.orgCode;
      console.log(food);
      window.alert(86);
      this.foodService.createFood(food).subscribe(  
        () => {  
          window.alert(87);
         // this.dataSaved = true;
         // this.massage = 'Record saved Successfully';  
          this.getAllFoods();  
        //  this.foodIdUpdate = null;  
        //  this.FoodForm.reset();  
        }  
      );  
  } /*else {  
      food.ID = this.foodIdUpdate;  
      this.foodService.updateFood(this.foodIdUpdate,food).subscribe(() => {  
       
       // this.massage = 'Record Updated Successfully';  
        this.getAllFoods();  
        this.foodIdUpdate = null;  
      //  this.FoodForm.reset();  
      });  
    }  
  }*/
  resetForm() {  
    this.FoodForm.reset();  
    this.dataSaved = false;
  }
 /*   return this.foodService.getFood("10706","1").subscribe(data =>
      { 
        this.resetForm();
        this.Food = data
        console.log(this.Food);
    });
    
  }
  resetForm(form?: NgForm){
    if(form = null)
    form.resetForm();
    this.foodService.formData = {
      
        ID: '',
        Quantity: '',
        FoodType: '', 
        PatientID: '',
        OrganizationCode: '',
        CreatedAt: '',
        CreatedBy: '',
        ModifiedAt: '',
        ModifiedBy: ''
    }
    
  } */



  
}

