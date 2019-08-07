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

    loginForm: FormGroup
  

    constructor(private _AuthS: AuthService, 
    private alertService: AlertService,
    private formBuilder: FormBuilder ) {}

  
  ngOnInit() {

      this.loginForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
  });
}

  
public login(this.loginForm.valid){

    this._AuthS.loginUser()
    .subscribe(data => this.loginData = data);
 
  }
}

  


