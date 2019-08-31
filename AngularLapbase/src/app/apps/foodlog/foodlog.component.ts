import { Component, AfterViewInit } from '@angular/core';
import { FoodService } from '../../services/food.service';
import {Food} from '../../models/Food';
import { DataService } from '../../services/data.service';
import { NgForm, FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
@Component({
  templateUrl: './foodlog.component.html'
})

export class FoodlogComponent implements AfterViewInit {
  
  patID: string;
  orgCode: string;
  allFoods: Observable<Food[]>;
 
  constructor(private formbuilder: FormBuilder, 
    private foodService: FoodService,
    public dataService: DataService) { }

  ngAfterViewInit() { 
    this.patID  = localStorage.getItem("patientID");
    this.orgCode = localStorage.getItem("organizationCode");
    this.getAllFoods();
  }
  getAllFoods(){
    this.allFoods = this.foodService.getFood(this.patID,this.orgCode);
  }
}
