import { Component } from '@angular/core';
import {AlertService} from '../../services/alert.service';
import { AuthService } from '../../services/auth.service';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import {Users} from '../../models/User';
import {Router} from '@angular/router';
import { Authorization } from '../../models/Authorization';
import { DataService } from '../../services/data.service';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html'
})
export class LoginComponent {
  constructor(private _AuthS: AuthService,
    public dataService: DataService,
    private formBuilder: FormBuilder,
    private router: Router ) {}

  //loginform = true;
  loginform:any
  model: Users = {
    UserName: "",
    Password: ""
  };
  ngOnInit() {
       
    this.loginform = this.formBuilder.group({
    Username: ['', Validators.required],
    Password: ['', Validators.required]
}); 
}
loginUser(event){
  event.preventDefault()
  const target = event.target
  this.model.UserName = target.querySelector('#Username').value
  this.model.Password = target.querySelector('#Password').value
  //console.log(this.model.UserName, this.model.Password) 


 //method to get user details
 this._AuthS.loginUserDetails(this.model).subscribe(data => {
  
    if(data === target.querySelector('#Username').value){
      this._AuthS.authorizedUser(target.querySelector('#Username').value).subscribe(
        data => {
          console.log(data);
          localStorage.setItem("patientID", data.PatientID);
          localStorage.setItem("organizationCode", data.OrganizationCode);
          localStorage.setItem("FirstName", data.FirstName);
            this.dataService.setPatientID(data.PatientID);
            this.dataService.setOrganizationCode(data.OrganizationCode);
            this.dataService.setFirstName(data.FirstName);
                });
      
   
    this.router.navigate(['../dashboard/classic'])
    
  }
  else{
    window.alert("The username or Password does not exits");
  }
 })


}
}
