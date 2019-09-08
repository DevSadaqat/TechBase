import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { NgbModalModule } from '@ng-bootstrap/ng-bootstrap';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { DragulaModule } from 'ng2-dragula';
import { QuillModule } from 'ngx-quill';
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';

import { AppsRoutes } from './apps.routing';
import { ExerciselogComponent } from './exerciselog/exerciselog.component';
import { FoodlogComponent } from './foodlog/foodlog.component';
import { AddfoodComponent } from './addfood/addfood.component';
import { DemographicComponent } from './demographic/demographic.component';
import { AddexerciseComponent } from './addexercise/addexercise.component';
import { DemographicdetailsComponent } from './demographicdetails/demographicdetails.component';
import { WeightComponent } from './weight/weight.component';
import { BmiComponent } from './bmi/bmi.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ExerciseComponent } from './exercise/exercise.component';
import { FoodComponent } from './food/food.component';


@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    NgbModalModule,
    CalendarModule.forRoot({
      provide: DateAdapter,
      useFactory: adapterFactory
    }),
    QuillModule.forRoot(),
    DragulaModule.forRoot(),
    RouterModule.forChild(AppsRoutes),
    PerfectScrollbarModule
  ],
  declarations: [
    ExerciselogComponent,
    FoodlogComponent,
    AddfoodComponent,
    DemographicComponent,
    AddexerciseComponent,
    DemographicdetailsComponent,
    WeightComponent,
    BmiComponent,
    DashboardComponent,
    ExerciseComponent,
    FoodComponent,
  ]
})
export class AppsModule { }
