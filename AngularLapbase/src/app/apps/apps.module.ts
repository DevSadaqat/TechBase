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
import { ChartsModule } from 'ng2-charts';
import { ChartistModule } from 'ng-chartist';
import { NgxChartsModule } from '@swimlane/ngx-charts';

import { AppsRoutes } from './apps.routing';

import { DashboardComponent } from './dashboard/dashboard.component';
import { DemographicComponent } from './demographic/demographic.component';
import { FoodComponent } from './food/food.component';
import { ExerciseComponent } from './exercise/exercise.component';



@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    NgbModalModule,
    ChartsModule,
    ChartistModule,
    NgxChartsModule,
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
    DashboardComponent,
    DemographicComponent,
    FoodComponent,
    ExerciseComponent
  ]
})
export class AppsModule { }
