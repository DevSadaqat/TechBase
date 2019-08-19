import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Users } from '../models/User';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  baseUrl: string = "http://localhost:81/Api/Login/Login";
  AuthorizationUrl = "http://localhost:81/Api/AuthorizeUser/AuthorizeUser";
  model: Users = {
    UserName: "",
    Password: ""}

  constructor(private http: HttpClient) {
      
   }
   loginUserDetails(model){
     return this.http.post<any>(this.baseUrl,  model);
    
   }
   authorizedUser(): Observable<any>{
  let params1 = new HttpParams().set('username', "TechInnovators")
    return this.http.get<any>(this.AuthorizationUrl, {params:params1});
   }

}
