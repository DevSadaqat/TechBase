import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IUsers } from '../models/User';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  baseUrl: string = "http://localhost:54726/Api/Login/Login/"
  m : IUsers;

  constructor(private http: HttpClient) {
      this.m = new IUsers( 'user', 'pass');
   }
   loginUser(): Observable<any>{
     return this.http.get<any>( this.baseUrl + this.m);
   }
}
