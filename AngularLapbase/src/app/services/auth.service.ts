import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders} from '@angular/common/http';
import { Users } from '../models/User';
import {Observable} from 'rxjs';
import {Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';


@Injectable({
  providedIn: 'root'
})
export class AuthService implements CanActivate{
  
  baseUrl: string = "http://localhost:81/Api/Login/Login";
  AuthorizationUrl = "http://localhost:81/Api/AuthorizeUser/AuthorizeUser?username=";
  model: Users = {
    UserName: "",
    Password: ""}
  

  constructor(private http: HttpClient,private router: Router) { }

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
    // If the previous URL was blank, then the user is directly accessing this page
    var activate = localStorage.getItem("authGuard");
    if (activate === "true") {
      return true;
    }
    else{
    this.router.navigate(['../authentication/login']);
    return false;}
  }
  loginUserDetails(model){
     return this.http.post<any>(this.baseUrl,  model);
    
   }
   authorizedUser(username:string){
    return this.http.get<any>(this.AuthorizationUrl+username);
   }
  
  




}
