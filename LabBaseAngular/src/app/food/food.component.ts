import { Component, OnInit } from '@angular/core';
import { FoodService } from '../services/food.service';
import {Food} from '../models/Food';

@Component({
  selector: 'app-food',
  templateUrl: './food.component.html',
  styleUrls: ['./food.component.css']
})
export class FoodComponent implements OnInit {

  Food: Food[];

  constructor(private foodService: FoodService) { }

  ngOnInit() {
    
    return this.foodService.getFood("10706","1").subscribe(data =>
      { 
        window.alert(1)
        this.Food = data
        console.log(this.Food);
    });
    
  }
}

