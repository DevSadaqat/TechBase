import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Food } from '../models/Food';

@Injectable({
  providedIn: 'root'
})
export class FoodService {

  baseUrl: string = "http://localhost:81/Api/Food"
  food: Food = {
   
    Quantity: "",
    FoodType: "",
    PatientID: "",
    OrganizationCode: ""
    
  }
  constructor(private http: HttpClient){}

  
  getFood(patId: string, organizationCode: string): Observable<Food[]> {
    return this.http.get<Food[]>
    (this.baseUrl + '/getFoods?PatientId=' + patId +'&OrganizationCode=' + organizationCode)
    }
    getFoodById(foodId: string): Observable<Food> {  
      return this.http.get<Food>(this.baseUrl + 
        '/getFoods?ID=' + foodId);  
    } 
    createFood(food): Observable<Food> {  
      return this.http.post<any>(this.baseUrl + '/PostFood',  food);  
    } 
    updateFood(id:string,food: Food): Observable<Food>  {  
      
      return this.http.put<Food>(this.baseUrl + '/ID=?'+id,  
      food);  
    } 

}
