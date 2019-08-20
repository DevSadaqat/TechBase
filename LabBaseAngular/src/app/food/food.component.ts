import { Component, OnInit } from '@angular/core';
import { FoodService } from '../services/food.service';


@Component({
  selector: 'app-food',
  templateUrl: './food.component.html',
  styleUrls: ['./food.component.css']
})
export class FoodComponent implements OnInit {

  constructor(private service: FoodService) { }

  ngOnInit() {
    this.service.getAll().subscribe((data) => {
      console.log('Result -', data);
    })
    
  }




}
