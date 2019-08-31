import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Patient} from '../models/Patient';

@Injectable({
  providedIn: 'root'
})
export class PatientService {

  baseUrl: string = "http://localhost:81/Api/Patient"
  patient: Observable<Patient> ;
  constructor(private http: HttpClient) { }

  //method to get patient demographics
  getPatientById(patId: string, organizationCode: string): Observable<Patient[]> {
 return this.http.get<Patient[]>(this.baseUrl + '/GetPatient?id=' + patId +'&organizationCode=' + organizationCode);
//  return this.patient;
  }

//method to update patient demograhics
updatePatient(patient: Patient): Observable<Patient> {
  const httpOptions = {headers: new HttpHeaders({'Content-type': 'appplication/json'})};
  return this.http.put<Patient>
  (this.baseUrl + '/UpdatePatient/', 
  patient , httpOptions);
  }
}
