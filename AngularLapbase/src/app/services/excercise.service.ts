import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Excercise } from '../models/excercise';
import { RecentExercise } from '../models/recentExercise';
import {Calories} from '../models/Calories';

@Injectable({
  providedIn: 'root'
})



export class ExcerciseService {

  "GET api/Exercise/GetCaloriesBurnt?PatientID={PatientID}&OrganizationCode={OrganizationCode}"

  baseUrl: string = "http://localhost:81/Api/Exercise"
  excerciseTypeUrl: string = "http://localhost:81/Api/ExerciseItem"

  exercise: Excercise = { 
    
    ExerciseName: "",
    Duration: "", 
    StartTime: "",
    PatientID: "", 
    OrganizationCode: ""
    }

  constructor(private http: HttpClient) {}

  getExercise(patId: string, organizationCode: string): Observable<Excercise[]> {
    return this.http.get<Excercise[]>
    (this.baseUrl + '/GetExercises?PatientId=' + patId +'&OrganizationCode=' + organizationCode)
    }

    createExercise(exercise): Observable<Excercise> {  
      return this.http.post<any>(this.baseUrl + '/PostExercise',  exercise);  
    }
    
    RecentExercise(patId: string, organizationCode: string): Observable<RecentExercise[]> {
      return this.http.get<RecentExercise[]>
      (this.baseUrl + '/GetRecentExercises?PatientID=' + patId +'&OrganizationCode=' + organizationCode)
      }
    //method to call burnt Calories
    CaloriesBurnt(patId: string, organizationCode: string): Observable<Calories[]> {
      return this.http.get<Calories[]>
      (this.baseUrl + '/GetCaloriesBurnt?PatientID=' + patId +'&OrganizationCode=' + organizationCode)
      }
    getIntenseExercises() {  
      return this.http.get<any> (this.excerciseTypeUrl +
        '/GetExerciseIntense');  
    }
    
    getModerateExercises() {  
      return this.http.get<any> (this.excerciseTypeUrl +
        '/GetExerciseModerate');  
    }

    getLightExercises(){  
      return this.http.get<any> (this.excerciseTypeUrl +
        '/GetExerciseLight');  
    }    
    //method to filter Excercise data
    filterLight(patId: string, organizationCode: string): Observable<Excercise[]>{
      return this.http.get<Excercise[]>
    (this.baseUrl + '/FilterLight/' + patId +'?OrganizationCode=' + organizationCode)
    }

    filterModerate(patId: string, organizationCode: string): Observable<Excercise[]>{
      return this.http.get<Excercise[]>
    (this.baseUrl + '/FilterModerate/' + patId +'?OrganizationCode=' + organizationCode)
    }

    filterIntense(patId: string, organizationCode: string): Observable<Excercise[]>{
      return this.http.get<Excercise[]>
    (this.baseUrl + '/FilterIntense/' + patId +'?OrganizationCode=' + organizationCode)
    }

    filterExerciseName(patId: string, organizationCode: string, exerciseName: string): Observable<Excercise[]>{
      return this.http.get<Excercise[]>
    (this.baseUrl + '/FilterExerciseName/' + patId +'?OrganizationCode=' + organizationCode + '&exerciseName='+exerciseName)
    }
}
