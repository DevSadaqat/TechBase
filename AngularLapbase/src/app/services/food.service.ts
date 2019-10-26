import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Food } from '../models/Food';
import { FoodItem } from '../models/FoodItem';
import { RecentFood } from '../models/recentFood';
import {Calories} from '../models/Calories';

@Injectable({
  providedIn: 'root'
})
export class FoodService {

  baseUrl: string = "http://localhost:81/Api/Food"
  foodItemUrl: string = "http://localhost:81/Api/FoodItem/GetFoodItems"
  drinksUrl: string = "http://localhost:81/Api/FoodItem/GetDrinks"
 //filter: string =  "http://localhost:81/api/Food"
 "http://localhost:81/api/Food/GetCaloriesConsumed?PatientID=27&OrganizationCode=2"
  food: Food = {
   
    Quantity: "",
    FoodName: "",
    MealType: "",
    PatientID: "",
    IntakeDate: "",
    OrganizationCode: ""
  }
  foodItem: FoodItem = {
    FoodName: "", 
    Calories: ""
  }
  
  constructor(private http: HttpClient){}

 //method to get all food from foodapi 
  getFood(patId: string, organizationCode: string): Observable<Food[]> {
    return this.http.get<Food[]>
    (this.baseUrl + '/getFoods?PatientId=' + patId +'&OrganizationCode=' + organizationCode)
    }
    getFoodItems(){
      return this.http.get<any> (this.foodItemUrl)
    }
    getDrinks(){
      return this.http.get<any> (this.drinksUrl)
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
    //method to display recent food
    RecentFood(patId: string, organizationCode: string): Observable<RecentFood[]> {
      return this.http.get<RecentFood[]>
      (this.baseUrl + '/getRecentFoods?PatientId=' + patId +'&OrganizationCode=' + organizationCode)
      }
    //method to call calories consumed api  
    CaloriesConsumed(patId: string, organizationCode: string): Observable<Calories[]> {
        return this.http.get<Calories[]>
        (this.baseUrl + '/GetCaloriesConsumed?PatientID=' + patId +'&OrganizationCode=' + organizationCode)
        }

    //methods to filter food data
    filterBreakfast(patId: string, organizationCode: string): Observable<Food[]> {
      return this.http.get<Food[]>
      (this.baseUrl + '/FilterBreakfast?PatientID=' + patId +'&OrganizationCode=' + organizationCode)
    }

    filterLunch(patId: string, organizationCode: string): Observable<Food[]> {
      return this.http.get<Food[]>
      (this.baseUrl + '/FilterLunch?PatientID=' + patId +'&OrganizationCode=' + organizationCode)
    }

    filterDinner(patId: string, organizationCode: string): Observable<Food[]> {
      return this.http.get<Food[]>
      (this.baseUrl + '/FilterDinner?PatientID=' + patId +'&OrganizationCode=' + organizationCode)
    }

    filterSmall(patId: string, organizationCode: string): Observable<Food[]> {
      return this.http.get<Food[]>
      (this.baseUrl + '/FilterSmall?PatientID=' + patId +'&OrganizationCode=' + organizationCode)
    }
    filterMedium(patId: string, organizationCode: string): Observable<Food[]> {
      return this.http.get<Food[]>
      (this.baseUrl + '/FilterMedium?PatientID=' + patId +'&OrganizationCode=' + organizationCode)
    }
    filterLarge(patId: string, organizationCode: string): Observable<Food[]> {
      return this.http.get<Food[]>
      (this.baseUrl + '/FilterLarge?PatientID=' + patId +'&OrganizationCode=' + organizationCode)
    }
    filterDrinks(patId: string, organizationCode: string): Observable<Food[]> {
      return this.http.get<Food[]>
      (this.baseUrl + '/FilterDrink?PatientID=' + patId +'&OrganizationCode=' + organizationCode)
    }

    filterFoodName(patId: string, organizationCode: string, foodName:string): Observable<Food[]> {
      return this.http.get<Food[]>
      (this.baseUrl + 'FilterFoodName?PatientID=' + patId +'&OrganizationCode=' + organizationCode + '&foodName=' + foodName)
    }

  





    

}
