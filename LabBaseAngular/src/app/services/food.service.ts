import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FoodService {

  baseUrl: string = 'http://localhost:54726/Api/Food'
  constructor(private http: HttpClient){}

  getAll(){
    return this.http.get(this.baseUrl);

  }
}
