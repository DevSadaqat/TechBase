import { Routes } from '@angular/router';

import { ExerciselogComponent } from './exerciselog/exerciselog.component';
import { FoodlogComponent } from './foodlog/foodlog.component';
import { AddfoodComponent } from './addfood/addfood.component';
import { WeightComponent } from './weight/weight.component';
import { AddexerciseComponent } from './addexercise/addexercise.component';
import { DemographicdetailsComponent} from './demographicdetails/demographicdetails.component';
import { BmiComponent } from './bmi/bmi.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FoodComponent } from './food/food.component';
import { ExerciseComponent } from './exercise/exercise.component';


export const AppsRoutes: Routes = [
  {
    path: '',
    children: [

      { path: 'dashboard',
        component: DashboardComponent,
        data: { title: 'Dashboard', urls: [{ title: 'Dashboard', url: '/apps/dashboard' }, { title: 'Dashboard' }] } },

      {
        path: 'food',
        component: FoodComponent,
        data: { title: 'Food', urls: [{ title: 'Dashboard', url: '/apps/dashboard' }, { title: 'Food' }] }
      },
      
      {
        path: 'exercise',
        component: ExerciseComponent,
        data: { title: 'Exercise', urls: [{ title: 'Dashboard', url: '/apps/dashboard' }, { title: 'Exercise' }] }
      },
      
      { path: 'exerciselog', 
      component: ExerciselogComponent, 
      data: { title: 'Exercise Log', urls: [ { title: 'Dashboard', url: '/apps/dashboard' }, { title: 'Exercise Log' } ] } },
      
      { path: 'foodlog', component: FoodlogComponent,
        data: { title: 'Food Log', urls: [ { title: 'Dashboard', url: '/apps/dashboard' }, { title: 'Food Log' } ] } },
      
      { path: 'addfood', component: AddfoodComponent,
        data: { title: 'Add Food', urls: [ { title: 'Dashboard', url: '/apps/dashboard' }, { title: 'Add Food' } ] } },
      
      { path: 'weight', component: WeightComponent, 
      data: { title: 'Weight', urls: [ { title: 'Dashboard', url: '/apps/dashboard' }, { title: 'Weight' } ] } },

      { path: 'bmi', component: BmiComponent,
        data: { title: 'BMI', urls: [{ title: 'Dashboard', url: '/apps/dashboard' }, { title: 'BMI' }] } },

      { path: 'demographicdetails', component: DemographicdetailsComponent, 
      data: { title: 'My Demographics', urls: [ { title: 'Dashboard', url: '/apps/dashboard' }, { title: 'My Demographics' } ] } },
      
      { path: 'addexercise', component: AddexerciseComponent,
        data: { title: 'Add Exercise Duration', urls: [ { title: 'Dashboard', url: '/apps/dashboard' }, { title: 'Add Exercise Duration' } ] } }
    ]
  }
];
