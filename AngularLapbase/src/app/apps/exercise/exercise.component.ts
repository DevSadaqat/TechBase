import { Component, AfterViewInit } from '@angular/core';
import { ExcerciseService } from '../../services/excercise.service';
import {Excercise} from '../../models/excercise';
import {ExerciseItem} from '../../models/ExerciseItem';
import { Observable } from 'rxjs';
import { ToastrService } from 'ngx-toastr';
import { NgbTimeStruct } from '@ng-bootstrap/ng-bootstrap';


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
    ExerciseType: "",
    Duration: "", 
    StartTime: "",
    PatientID: "", 
    OrganizationCode: ""
  }
  exerciseIntense: ExerciseItem = {
    ExerciseName: "",
    ExerciseType: "", 
    Calories: "" 
  }
  exerciseLight: ExerciseItem = {
    ExerciseName: "",
    ExerciseType: "", 
    Calories: "" 
  }
  exerciseModerate: ExerciseItem = {
    ExerciseName: "",
    ExerciseType: "", 
    Calories: "" 
  }

 
  constructor(private exerciseService: ExcerciseService, private toastr: ToastrService) { }

  lightExercise() {
    this.toastr.success('Your Light Exercise is Added!', 'Success!');
  }

  moderateExercise() {
    this.toastr.success('Your Moderate Exercise is Added!', 'Success!');
  }

  intenseExercise() {
    this.toastr.success('Your Intense Exercise is Added!', 'Success!');
  }

  meridian = true;
  seconds = true;
  toggleSeconds() {
    this.seconds = !this.seconds;
  }

  

  ngAfterViewInit() {
    this.patID  = localStorage.getItem("patientID");
    this.orgCode = localStorage.getItem("organizationCode");
    this.getAllExercises;
    
    //method to display list of exercises 
    this.exerciseService.getIntenseExercises().subscribe(data => {
      this.exerciseIntense = data;
      console.log(this.exerciseIntense);
    })

    this.exerciseService.getModerateExercises().subscribe(data => {
      this.exerciseModerate = data;
      console.log(this.exerciseModerate);
    })

    this.exerciseService.getLightExercises().subscribe(data => {
      this.exerciseLight = data;
      console.log(this.exerciseLight);
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
    //window.alert(97);
    event.preventDefault()
    const target = event.target
   
    this.exercise.ExerciseName =target.querySelector('#excName').value
    this.exercise.ExerciseType =target.querySelector('#exctype').value
    this.exercise.Duration = target.querySelector('#Duration').value
    console.log(this.exercise); 
    //window.alert(97); 
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
