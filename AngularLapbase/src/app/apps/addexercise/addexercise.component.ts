import { Component, AfterViewInit } from '@angular/core';
import { ExcerciseService } from '../../services/excercise.service';
import {Excercise} from '../../models/excercise';
import { DataService } from '../../services/data.service';

@Component({
  selector: 'app-addexercise',
  templateUrl: './addexercise.component.html',
  styleUrls: ['./addexercise.component.scss']
})

export class AddexerciseComponent implements AfterViewInit {
  ExerciseForm: any;
  patID: string;
  orgCode: string;
  exercise: Excercise = {

    ExerciseType: "",
    Duration: "", 
    PatientID: "", 
    OrganizationCode: ""
  }
  constructor(private exerciseService: ExcerciseService,
    public dataService: DataService) { }
  ngAfterViewInit() { 

    this.patID  = localStorage.getItem("patientID");
    this.orgCode = localStorage.getItem("organizationCode");
  }
  ExerciseUser(event){
     window.alert(97);
     event.preventDefault()
     const target = event.target
    
     this.exercise.ExerciseType =target.querySelector('#excType').value
     this.exercise.Duration = target.querySelector('#Duration').value
     console.log(this.exercise);
     window.alert(97);
     this.CreateExercise(this.exercise);
   }

   //method to create excercise
     CreateExercise(exercise: Excercise) {
     exercise.PatientID = this.patID;
     exercise.OrganizationCode = this.orgCode;

     //calling of api method to add exercise

     this.exerciseService.createExercise(exercise).subscribe(
    () => {
          window.alert(10);
     }
     );
   }
}

