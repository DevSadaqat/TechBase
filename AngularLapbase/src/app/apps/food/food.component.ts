import { Component, OnInit, AfterViewInit } from '@angular/core';
import { FoodService } from '../../services/food.service';
import {Food} from '../../models/Food';
import { FoodItem } from '../../models/FoodItem';
import {RecentFood} from '../../models/recentFood';
import { Observable } from 'rxjs';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-food',
  templateUrl: './food.component.html',
  styleUrls: ['./food.component.css']
})
export class FoodComponent implements AfterViewInit {
  foodValue: string;
  selectedLevel;
  data:Array<Object> = [
      { name: "Breakfast"},
      { name: "Lunch"},
      { name: "Dinner"},
      { name: "Small"},
      { name: "Medium"},
      { name: "Large"},
  ];
  selected(){
    this.foodValue = (this.selectedLevel.name);
    this.getAllFoods();
  }
  patID: string;
  orgCode: string;
  allFoods: Observable<Food[]>;
  recentfoods: Observable<RecentFood[]>
  allFoodItems: Observable<FoodItem[]>;
  food: Food = {
    Quantity: "",
    FoodName:"", 
    MealType: "",
    IntakeTime:"",
    PatientID: "",
    OrganizationCode: ""
    }
    foodItem: FoodItem = {
      FoodName:"",
      Calories:""
    }
    recentFood: RecentFood = {
      Quantity: "",
      FoodName:"", 
      MealType: "",
      IntakeTime:"",
      PatientID: "",
      OrganizationCode: ""
    }
    
  constructor(private foodService: FoodService, private toastr: ToastrService) {}

  breakfast() {
    this.toastr.success('Your Breakfast is Added!', 'Success!');
  }

  lunch() {
    this.toastr.success('Your Lunch is Added!', 'Success!');
  }

  dinner() {
    this.toastr.success('Your Dinner is Added!', 'Success!');
  }

  drinks() {
    this.toastr.success('Your Drink is Added!', 'Success!');
  }


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
    this.getRecentFood();

    
  }
  
  // getAllFoodItems(){
 
  //   this.allFoodItems = this.foodService.getFoodItems();
  //   console.log(this.allFoodItems);
  // }

  getAllFoods(){
   
    if(this.foodValue==="Breakfast")
    {
      this.allFoods = this.foodService.filterBreakfast(this.patID,this.orgCode);  
      }
    else if(this.foodValue==="Lunch")
    {
      this.allFoods = this.foodService.filterLunch(this.patID,this.orgCode);  
      }
    else if(this.foodValue==="Dinner")
    {
      this.allFoods = this.foodService.filterDinner(this.patID,this.orgCode); 
       }
       else if(this.foodValue==="Small")
    {
      this.allFoods = this.foodService.filterSmall(this.patID,this.orgCode); 
       }
       else if(this.foodValue==="Medium")
    {
      this.allFoods = this.foodService.filterMedium(this.patID,this.orgCode); 
       }
       else if(this.foodValue==="Large")
    {
      this.allFoods = this.foodService.filterLarge(this.patID,this.orgCode); 
       }
    else{
      this.allFoods = this.foodService.getFood(this.patID,this.orgCode);
    }
  }
  getRecentFood(){
    this.recentfoods = this.foodService.RecentFood(this.patID,this.orgCode);
  }
  foodUser(event){
    // window.alert(97);
    // this.FoodForm=FoodForm;
     event.preventDefault()
     const target = event.target
     this.food.FoodName =target.querySelector('#FoodName').value
     this.food.MealType =target.querySelector('#MealType').value
     this.food.Quantity = target.querySelector('#Quantity').value
     this.food.IntakeTime = target.querySelector('#IntakeTime').value
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
          this.getRecentFood();
           this.getAllFoods();  
    
         }  
       );  
   }
}
