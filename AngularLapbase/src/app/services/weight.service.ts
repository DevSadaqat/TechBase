import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Weight } from '../models/Weight';
import { WeightList } from '../models/weightList';
@Injectable({
  providedIn: 'root'
})
export class WeightService {

  baseUrl: string = "http://localhost:81/Api/Weight"
  // http://localhost:81/api/Weight/GetAllWeights?PatientID=27&OrganizationCode=2
  weight: Weight = {

    WeightValue: "",
    PatientID: "",
    OrganizationCode: "",
  }
  latestWeight: Observable<Weight>;
  
  constructor(private http: HttpClient) {}

  createWeight(weight): Observable<Weight> {  
    return this.http.post<any>(this.baseUrl + '/PostWeight',  weight);  
  } 
  getWeight(patId: string, organizationCode: string): Observable<Weight[]> {
    return this.http.get<Weight[]>
    (this.baseUrl + '/getWeights?PatientId=' + patId +'&OrganizationCode=' + organizationCode)
    }
    getLatestWeight(patId: string, organizationCode: string): Observable<Weight> {
      this.latestWeight = this.http.get<Weight>
      (this.baseUrl + '/getLatestWeight?PatientId=' + patId +'&OrganizationCode=' + organizationCode)  
      return this.latestWeight;
      }
    
  getAllWeights(patId: string, organizationCode: string): Observable<WeightList> {
    return this.http.get<WeightList>
    (this.baseUrl + '/GetAllWeights?PatientID=' + patId +'&OrganizationCode=' + organizationCode)
    }
}
