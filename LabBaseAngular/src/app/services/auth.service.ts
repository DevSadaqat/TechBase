import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Users } from '../models/User';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  baseUrl: string = "http://localhost:54726/Api/Login/Login/"
  m : Users;

  constructor(private http: HttpClient) {
      this.m = new Users( 'user', 'pass');
   }
   loginUserDetails(){
     return this.http.post<any>(' this.baseUrl',  this.m).subscribe(data => {
       console.log(data, "is the response from server")
     });
   }
}
