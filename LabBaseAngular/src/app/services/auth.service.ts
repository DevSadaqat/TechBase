import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Users } from '../models/User';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  baseUrl: string = "http://localhost:81/Api/Login/Login"
  model: Users = {
    UserName: "",
    Password: ""}

  constructor(private http: HttpClient) {
      
   }
   loginUserDetails(model){
     return this.http.post<any>(this.baseUrl,  model)
   }
}
