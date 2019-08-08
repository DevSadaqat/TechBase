import { Component, OnInit } from '@angular/core';
import {AlertService} from '../services/alert.service';
import { AuthService } from '../services/auth.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {Users} from '../models/User';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent  {

    loginForm: FormGroup
    user: Users = {
      UserName: "",
      Password: ""
    };


    constructor(private _AuthS: AuthService, 
    private alertService: AlertService,
    private formBuilder: FormBuilder,
    //private user: Users = new Users("UserName",  "Password"),
     ) {}

  
  ngOnInit() {

      this.loginForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
  });
}

  //method to get details of user from login form 
  loginUser(event){
    event.preventDefault()
    const target = event.target
    this.user.UserName = target.querySelector('#username').value
    this.user.Password = target.querySelector('#password').value
    console.log(this.user.UserName, this.user.Password) 
  }



   //method to get user details
    //this._AuthS.loginUser()
    //.subscribe(data => this.loginData = data);
 
  
}

  


