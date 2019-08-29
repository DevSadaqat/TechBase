import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { NotifierModule } from 'angular-notifier';

import { ComponentsRoutes } from './component.routing';

import { NgbdBmiBasicComponent } from './bmi/bmi.component';
import { NgbdCaloriesBasicComponent } from './calories/calories.component';
import { NgbdWeightBasicComponent } from './weight/weight.component';


@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(ComponentsRoutes),
    FormsModule,
    ReactiveFormsModule,
    NgbModule,
	NotifierModule
  ],
  declarations: [ 
    NgbdBmiBasicComponent,
    NgbdCaloriesBasicComponent,
    NgbdWeightBasicComponent,
   
  ]
})
export class ComponentsModule {}
