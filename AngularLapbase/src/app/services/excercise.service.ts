import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Excercise } from '../models/excercise';

@Injectable({
  providedIn: 'root'
})



export class ExcerciseService {

  baseUrl: string = "http://localhost:54726/Api/Exercise"
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
