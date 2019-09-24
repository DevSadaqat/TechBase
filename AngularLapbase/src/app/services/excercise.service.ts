import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Excercise } from '../models/excercise';

@Injectable({
  providedIn: 'root'
})



export class ExcerciseService {

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
    /*
    getModerateExercises(exerciseId: string): Observable<Excercise> {  
      return this.http.get<Excercise>(this.baseUrl + 
        '/GetExercises?ID=' + exerciseId);  
    } 
    
    getLightExercises(exerciseId: string): Observable<Excercise> {  
      return this.http.get<Excercise>(this.baseUrl + 
        '/GetExercises?ID=' + exerciseId);  
    } 

   
   /* updateFood(id:string,food: Food): Observable<Food>  {  
      
      return this.http.put<Food>(this.baseUrl + '/ID=?'+id,  
      food);  
    }
    */
}
