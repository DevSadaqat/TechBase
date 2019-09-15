import { Component, AfterViewInit } from '@angular/core';
import { ExcerciseService } from '../../services/excercise.service';
import {Excercise} from '../../models/excercise';
import {ExerciseItem} from '../../models/ExerciseItem';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-exercise',
  templateUrl: './exercise.component.html',
  styleUrls: ['./exercise.component.css']
})
export class ExerciseComponent implements AfterViewInit {

  patID: string;
  orgCode: string;
  allExercises: Observable<Excercise[]>;
  exercise: Excercise = {
    ExerciseName: "",
    Duration: "", 
    StartTime: "",
    PatientID: "", 
    OrganizationCode: ""
  }
  exerciseItem: ExerciseItem = {
    ExerciseName: "",
    ExerciseType: "", 
    Calories: "" 
  }

  constructor(private exerciseService: ExcerciseService) { }

  ngAfterViewInit() {
    this.patID  = localStorage.getItem("patientID");
    this.orgCode = localStorage.getItem("organizationCode");
    this.getAllExercises;
    
    //method to display list of exercises 
    this.exerciseService. getIntenseExercises().subscribe(data => {
      this.exerciseItem = data;
      console.log(this.exerciseItem);
    })

    this.exerciseService.getModerateExercises().subscribe(data => {
      this.exerciseItem = data;
      console.log(this.exerciseItem);
    })

    this.exerciseService.getLightExercises().subscribe(data => {
      this.exerciseItem = data;
      console.log(this.exerciseItem);
    })



    // this.exerciseService.getExercise(this.patID, this.orgCode).subscribe(data =>
    //   this.exercise = data)
    //   console.log(this.exercise)
  }
  getAllExercises(){
    this.allExercises = this.exerciseService.getExercise(this.patID,this.orgCode);
    console.log(this.allExercises);
  }
  ExerciseUser(event){
    window.alert(97);
    event.preventDefault()
    const target = event.target
   
    this.exercise.ExerciseName =target.querySelector('#excType').value
    this.exercise.Duration = target.querySelector('#Duration').value
    console.log(this.exercise); 
    window.alert(97); 
    this.CreateExercise(this.exercise);
  }

  //method to create excercise
    CreateExercise(exercise: Excercise) {
    exercise.PatientID = this.patID;
    exercise.OrganizationCode = this.orgCode;

    this.CreateExercise(exercise);
    //calling of api method to add exercise

    this.exerciseService.createExercise(exercise).subscribe(
   () => {
         window.alert(10);
         this.getAllExercises();
    }
    );
  }

}
