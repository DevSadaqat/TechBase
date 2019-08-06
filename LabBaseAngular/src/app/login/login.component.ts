import { Component, OnInit } from '@angular/core';
import {AlertService} from '../services/alert.service';
import { AuthService } from '../services/auth.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent  {

  loginForm: FormGroup;
  loginData = []

  constructor(private _AuthS: AuthService, 
    private alertService: AlertService,
    private formBuilder: FormBuilder ) {}
 
    login(){
    console.log(this.loginData);
  }
  ngOnInit() {

    this.loginForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
  });

    this._AuthS.getUser()
    .subscribe(data => this.loginData = data);
    }

  }


