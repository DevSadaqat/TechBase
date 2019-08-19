import { Component, OnInit } from '@angular/core';
import {AlertService} from '../services/alert.service';
import { AuthService } from '../services/auth.service';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import {Users} from '../models/User';
import {Router} from '@angular/router';
import { Authorization } from '../models/Authorization';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent  {

    loginForm: any
    model: Users = {
      UserName: "",
      Password: ""
    };
    authori: Authorization[];



    constructor(private _AuthS: AuthService,   
    private alertService: AlertService,
    private formBuilder: FormBuilder,
    private router: Router
     ) {}

  
  ngOnInit() {

      return this._AuthS.authorizedUser().subscribe(data => this.authori = data);
      
     
      this.loginForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
  });
}

  //method to get details of user from login form 
  loginUser(event){
    event.preventDefault()
    const target = event.target
    this.model.UserName = target.querySelector('#username').value
    this.model.Password = target.querySelector('#password').value
    //console.log(this.model.UserName, this.model.Password) 
  

   //method to get user details
   this._AuthS.loginUserDetails(this.model).subscribe(data => {
    window.alert(1)
  
    //console.log(data.authenticate = true, "is the response from server")
      if(data === target.querySelector('#username').value){
        
      // this._AuthS.authorizedUser(data).subscribe()
      // window.alert(2)

      this.router.navigate(['/sidenav'])
      //redirect home  
    }
    else{
      window.alert("The username or Password does not exits");
    }
   })

  
}

}


