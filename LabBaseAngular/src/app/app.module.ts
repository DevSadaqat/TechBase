import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http'
import {RouterModule} from '@angular/router';

//forms
import {ReactiveFormsModule, FormsModule} from '@angular/forms';
import { AppRoutingModule, routingComponents } from './app-routing.module'

//material design
import { MaterialModule } from "./material/material.module";

//components
//import { DemographicComponent } from './demographic/demographic.component';
//import { ExcerciseComponent } from './excercise/excercise.component';
//import { FoodComponent } from './food/food.component';
import { AppComponent } from './app.component';
//import { LoginComponent } from './login/login.component';
//import { SidenavComponent } from './sidenav/sidenav.component';
//services
import {AuthService} from './services/auth.service';
import {AlertService} from './services/alert.service';
import { NotFoundComponent } from './not-found/not-found.component';
import { AlertComponent } from './alert/alert.component';
//import { SidenavComponent } from './sidenav/sidenav.component';
//import { WeightComponent } from './weight/weight.component';
//import { DashboardComponent } from './dashboard/dashboard.component';



@NgModule({
  declarations: [
    AppComponent,
    AlertComponent,
    //LoginComponent,
    routingComponents,
    NotFoundComponent,
    //SidenavComponent,
    
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule, 
    MaterialModule,                                                            
    ReactiveFormsModule, FormsModule,
    RouterModule
  ],
  providers: [AuthService, AlertService],
  bootstrap: [AppComponent]
})
export class AppModule { }
