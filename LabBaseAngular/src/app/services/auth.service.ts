import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders} from '@angular/common/http';
import { Users } from '../models/User';
import {Observable} from 'rxjs';
import {Authorization} from  '../models/Authorization';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  
  baseUrl: string = "http://localhost:81/Api/Login/Login";
  AuthorizationUrl = "http://localhost:81/Api/AuthorizeUser/AuthorizeUser?username=";
  model: Users = {
    UserName: "",
    Password: ""}
  

  constructor(private http: HttpClient) {
      
   }
   loginUserDetails(model){
     return this.http.post<any>(this.baseUrl,  model);
    
   }
   authorizedUser(username:string){
    return this.http.get<any>(this.AuthorizationUrl+username);
   }
  
  //authorizedUser(username: string){
 // authorizedUser(username:string){
 // let headers = new HttpHeaders({'Content-Type':'application/json'});
  //headers.append('Content-Type', 'application/json');   
  //let myHeaders = new Headers();
 // myHeaders.append('Content-Type', 'application/json');  
 // let myParams = new URLSearchParams(); 
 // let params  = new HttpParams();
// params.set('username', username);
//myParams.append('username', username);
  //headers.search = params; 
//return this.http.get<any>(this.AuthorizationUrl, {headers: headers, params: params});
// return this.http.get<any>(this.AuthorizationUrl,{params:  params});}
 




}
