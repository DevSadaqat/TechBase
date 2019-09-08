import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Weight } from '../models/Weight';
@Injectable({
  providedIn: 'root'
})
export class WeightService {

  baseUrl: string = "http://localhost:81/Api/Weight"
  weight: Weight = {

    WeightValue: "",
    PatientID: "",
    OrganizationCode: "",
  }
  constructor(private http: HttpClient) {}

  createWeight(weight): Observable<Weight> {  
    return this.http.post<any>(this.baseUrl + '/PostWeight',  weight);  
  } 
  getWeight(patId: string, organizationCode: string): Observable<Weight[]> {
    return this.http.get<Weight[]>
    (this.baseUrl + '/getWeights?PatientId=' + patId +'&OrganizationCode=' + organizationCode)
    }
}
