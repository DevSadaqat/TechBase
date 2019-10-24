import { Component, AfterViewInit } from '@angular/core';
import { ExcerciseService } from '../../services/excercise.service';
import {Excercise} from '../../models/excercise';
import {ExerciseItem} from '../../models/ExerciseItem';
import {RecentExercise} from '../../models/recentExercise';
import { Observable } from 'rxjs';
import { ToastrService } from 'ngx-toastr';
import { NgbTimeStruct } from '@ng-bootstrap/ng-bootstrap';
import * as moment from 'moment';


@Component({
  selector: 'app-exercise',
  templateUrl: './exercise.component.html',
  styleUrls: ['./exercise.component.css']
})
export class ExerciseComponent implements AfterViewInit {
  
  
    patID: string;
    orgCode: string;
    recentexercise: Observable<RecentExercise[]>
    selectedLevel;
    filterBy: string;
    data:Array<Object> = [
      { name: "Light"},
      { name: "Moderate"},
      { name: "Intense"}     
  ];
    selected(){
      this.filterBy = (this.selectedLevel.name);
      
      this.getAllExercises();
    }
    allExercises: Observable<Excercise[]>;
    // exercise1: Excercise[];
    exercise: Excercise = {
    ExerciseName: "",
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
    this.getAllExercises();
    this.getRecentExercise();
    
    
    //methods to display list of exercises 
    this.exerciseService.getIntenseExercises().subscribe(data => {
      this.exerciseIntense = data;
      console.log(this.exerciseIntense);
    })

    this.exerciseService.getModerateExercises().subscribe(data => {
      this.exerciseModerate = data;
      //console.log(this.exerciseModerate);
    })

    this.exerciseService.getLightExercises().subscribe(data => {
      this.exerciseLight = data;
      //console.log(this.exerciseLight);
    })

    //method to get all exercises list
    //  this.exerciseService.getExercise(this.patID, this.orgCode).subscribe(data => {
          
    //   this.exercise1 = data;
    //  console.log(this.exercise1);
    //  })
  }
  getAllExercises(){
    if(this.filterBy==="Light")
    {
    this.allExercises = this.exerciseService.filterLight(this.patID,this.orgCode);
    }
    else if(this.filterBy==="Moderate")
    {
    this.allExercises = this.exerciseService.filterModerate(this.patID,this.orgCode);
    }
    else if(this.filterBy==="Intense")
    {
    this.allExercises = this.exerciseService.filterIntense(this.patID,this.orgCode);
    }
    else{
      this.allExercises = this.exerciseService.getExercise(this.patID,this.orgCode);
    }
  }
  //method to display recent exercise 
  getRecentExercise(){
    this.recentexercise = this.exerciseService.RecentExercise(this.patID,this.orgCode);
  }
  
  ExerciseUser(event){
    //window.alert(97);
    event.preventDefault()
    const target = event.target
   
    // this.exercise.ExerciseName =target.querySelector('#excName').value
    this.exercise.ExerciseName =target.querySelector('#exctype').value
    this.exercise.Duration = target.querySelector('#Duration').value
    var time = target.querySelector('#StartTime').value
     let myDate:string = moment().format("YYYY-MM-DD");
    this.exercise.StartTime = myDate+"T"+time+":00.000"
  
    console.log(this.exercise); 
    //window.alert(97); 
    this.CreateExercise(this.exercise);
  }
  

  //method to create excercise
    CreateExercise(exercise: Excercise) {
    exercise.PatientID = this.patID;
    exercise.OrganizationCode = this.orgCode;

    //this.CreateExercise(exercise);
    //calling of api method to add exercise

    this.exerciseService.createExercise(exercise).subscribe(
   () => {
         window.alert(10);
         this.getRecentExercise();
         this.getAllExercises();

    }
    );
  }

}

