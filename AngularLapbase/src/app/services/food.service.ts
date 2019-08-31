import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Food } from '../models/Food';

@Injectable({
  providedIn: 'root'
})
export class FoodService {

  baseUrl: string = "http://localhost:81/Api/Food"
  constructor(private http: HttpClient){}

  getFood(patId: string, organizationCode: string): Observable<Food[]> {
    return this.http.get<Food[]>
    (this.baseUrl + '/getFoods?PatientId=' + patId +'&OrganizationCode=' + organizationCode)
    }
}
