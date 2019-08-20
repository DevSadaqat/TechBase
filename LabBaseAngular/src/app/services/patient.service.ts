import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Patient} from '../models/Patient';

@Injectable({
  providedIn: 'root'
})
export class PatientService {

  baseUrl: string = "http://localhost:81/Api/Patient"
  constructor(private http: HttpClient) { }
//  http://localhost:54726/Api/Patient/getPatient?id=10706&organizationCode=1
  //method to get patient demographics
  getPatientById(patId: string, organizationCode: string): Observable<Patient[]> {
  return this.http.get<Patient[]>
  (this.baseUrl + '/GetPatient?id=' + patId +'&organizationCode=' + organizationCode)
  }

//method to update patient demograhics
updatePatient(patient: Patient): Observable<Patient> {
  const httpOptions = {headers: new HttpHeaders({'Content-type': 'appplication/json'})};
  return this.http.put<Patient>
  (this.baseUrl + '/UpdatePatient/', 
  patient , httpOptions);
  }
}
