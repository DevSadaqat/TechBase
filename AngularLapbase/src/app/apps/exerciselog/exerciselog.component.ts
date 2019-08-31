import { Component, AfterViewInit } from '@angular/core';
import { ExcerciseService } from '../../services/excercise.service';
import {Excercise} from '../../models/excercise';
import { DataService } from '../../services/data.service';
import { Observable } from 'rxjs';

@Component({
  templateUrl: './exerciselog.component.html'
})
export class ExerciselogComponent implements AfterViewInit {

  patID: string;
  orgCode: string;
  allExercises: Observable<Excercise[]>;

  constructor(private excerciseService: ExcerciseService ,
    public dataService: DataService){}

  ngAfterViewInit() { 
    this.patID  = localStorage.getItem("patientID");
    this.orgCode = localStorage.getItem("organizationCode");
    this.getAllExercises();
  }
  getAllExercises(){
    this.allExercises = this.excerciseService.getExercise(this.patID,this.orgCode);
  }
}

  