import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Weight } from '../models/Weight';
import { WeightList } from '../models/weightList';
import { Bmi } from '../models/Bmi';
import { BmiList } from '../models/bmiList';
@Injectable({
  providedIn: 'root'
})
export class WeightService {

  baseUrl: string = "http://localhost:81/Api/Weight"
  bmiUrl: string = "http://localhost:81/api/BMICalculator"
  
  weight: Weight = {

    WeightValue: "",
    PatientID: "",
    OrganizationCode: "",
    BMI: ""
  }
 
  constructor(private http: HttpClient) {}

  createWeight(weight): Observable<Weight> {  
    return this.http.post<any>(this.baseUrl + '/PostWeight',  weight);  
  } 
  getWeight(patId: string, organizationCode: string): Observable<Weight[]> {
    return this.http.get<Weight[]>
    (this.baseUrl + '/getWeights?PatientId=' + patId +'&OrganizationCode=' + organizationCode)
    }

    getLatestWeight(patId: string, organizationCode: string): Observable<Weight> {
      return this.http.get<Weight>
      (this.baseUrl + '/getLatestWeight?PatientId=' + patId +'&OrganizationCode=' + organizationCode) 
      }
   
  //method returns list all weights
  getAllWeights(patId: string, organizationCode: string ): Observable<WeightList[]> {
    return this.http.get<WeightList[]>
    (this.baseUrl + '/GetAllWeights?PatientID=' + patId +'&OrganizationCode=' + organizationCode)
    }
 //method for BMI
    getBmi(patId: string, organizationCode: string, weight: string): Observable<Bmi> {
      return this.http.get<Bmi>
      (this.bmiUrl + '/CalculateBMI?PatientID=' + patId +'&OrganizationCode=' + organizationCode + '&weight=' + weight )
      }
  //method for to display BMI in graph
  getBmiForGraph(patId: string, organizationCode: string ): Observable<BmiList[]> {
    return this.http.get<BmiList[]>
    (this.baseUrl + '/GetAllBMIs?PatientID=' + patId +'&OrganizationCode=' + organizationCode)
    }
  
}
