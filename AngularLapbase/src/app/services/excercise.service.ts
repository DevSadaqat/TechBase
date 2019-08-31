import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Excercise } from '../models/excercise';

@Injectable({
  providedIn: 'root'
})



export class ExcerciseService {

  baseUrl: string = "http://localhost:81/Api/Exercise"

  exercise: Excercise = { 
    //ID: "",
    ExerciseType: "",
    Duration: "" ,
    PatientID: "", 
    OrganizationCode: ""
    }

  constructor(private http: HttpClient) {}

  getExercise(patId: string, organizationCode: string): Observable<Excercise[]> {
    return this.http.get<Excercise[]>
    (this.baseUrl + '/GetExercises?PatientId=' + patId +'&OrganizationCode=' + organizationCode)
    }
    
    getExcersieById(exerciseId: string): Observable<Excercise> {  
      return this.http.get<Excercise>(this.baseUrl + 
        '/GetExercises?ID=' + exerciseId);  
    } 
    createExercise(exercise): Observable<Excercise> {  
      return this.http.post<any>(this.baseUrl + '/PostExercise',  exercise);  
    } 
   
   /* updateFood(id:string,food: Food): Observable<Food>  {  
      
      return this.http.put<Food>(this.baseUrl + '/ID=?'+id,  
      food);  
    }
    */
}
