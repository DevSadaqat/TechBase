import { Component, OnInit, AfterViewInit } from '@angular/core';
import { FoodService } from '../../services/food.service';
import {Food} from '../../models/Food';
import { FoodItem } from '../../models/FoodItem';
import { Observable } from 'rxjs';


@Component({
  selector: 'app-food',
  templateUrl: './food.component.html',
  styleUrls: ['./food.component.css']
})
export class FoodComponent implements AfterViewInit {

  patID: string;
  orgCode: string;
  allFoods: Observable<Food[]>;
  allFoodItems: Observable<FoodItem[]>;
  food: Food = {
    Quantity: "",
    FoodName:"", 
    MealType: "",
    PatientID: "",
    OrganizationCode: ""
    }
    foodItem: FoodItem = {
      FoodName:"",
      Calories:""
    }

  constructor(private foodService: FoodService,

  ) {}

  ngAfterViewInit() {
    this.patID  = localStorage.getItem("patientID");
    this.orgCode = localStorage.getItem("organizationCode");
    console.log(this.patID);

    this.foodService.getFood(this.patID,this.orgCode);
    
    //mehod to get list of food item
    this.foodService.getFoodItems().subscribe(data => {
      this.foodItem = data;
      console.log(this.foodItem);
    })
    this.getAllFoods();
   // this.getAllFoodItems();
    
  }
  
  // getAllFoodItems(){
 
  //   this.allFoodItems = this.foodService.getFoodItems();
  //   console.log(this.allFoodItems);
  // }

  getAllFoods(){
   
    this.allFoods = this.foodService.getFood(this.patID,this.orgCode);
  }
  foodUser(event){
    // window.alert(97);
    // this.FoodForm=FoodForm;
     event.preventDefault()
     const target = event.target
     this.food.FoodName =target.querySelector('#FoodName').value
     this.food.MealType =target.querySelector('#MealType').value
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
           this.getAllFoods();  
         //  this.foodIdUpdate = null;  
         //  this.FoodForm.reset();  
         }  
       );  
   }
}
