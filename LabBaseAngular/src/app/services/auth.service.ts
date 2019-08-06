import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IUsers } from '../models/User';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  baseUrl: string = "http://localhost:54726/Api/Login/Login"
  
  constructor(private http: HttpClient) {

   }
   getUser(): Observable<IUsers[]>{
     return this.http.get<IUsers[]>(this.baseUrl);
   }
}
