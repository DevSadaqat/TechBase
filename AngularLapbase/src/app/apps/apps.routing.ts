import { Routes } from '@angular/router';

import { ExerciselogComponent } from './exerciselog/exerciselog.component';
import { FoodlogComponent } from './foodlog/foodlog.component';
import { AddfoodComponent } from './addfood/addfood.component';
import { WeightComponent } from './weight/weight.component';
import { AddexerciseComponent } from './addexercise/addexercise.component';
import { DemographicdetailsComponent} from './demographicdetails/demographicdetails.component';
import { BmiComponent } from './bmi/bmi.component';


export const AppsRoutes: Routes = [
  {
    path: '',
    children: [
      
      {path: 'exerciselog', 
      component: ExerciselogComponent, 
      data: { title: 'Exercise Log', urls: [ { title: 'Dashboard', url: '/dashboard/classic' }, { title: 'Exercise Log' } ] } },
      
      { path: 'foodlog', component: FoodlogComponent,
        data: { title: 'Food Log', urls: [ { title: 'Dashboard', url: '/dashboard/classic' }, { title: 'Food Log' } ] } },
      
      { path: 'addfood', component: AddfoodComponent,
        data: { title: 'Add Food', urls: [ { title: 'Dashboard', url: '/dashboard/classic' }, { title: 'Add Food' } ] } },
      
      { path: 'weight', component: WeightComponent, 
      data: { title: 'Weight', urls: [ { title: 'Dashboard', url: '/dashboard/classic' }, { title: 'Weight' } ] } },

      { path: 'bmi', component: BmiComponent,
        data: { title: 'BMI', urls: [{ title: 'Dashboard', url: '/dashboard/classic' }, { title: 'BMI' }] } },

      { path: 'demographicdetails', component: DemographicdetailsComponent, 
      data: { title: 'My Demographics', urls: [ { title: 'Dashboard', url: '/dashboard/classic' }, { title: 'My Demographics' } ] } },
      
      { path: 'addexercise', component: AddexerciseComponent,
        data: { title: 'Add Exercise Duration', urls: [ { title: 'Dashboard', url: '/dashboard/classic' }, { title: 'Add Exercise Duration' } ] } }
    ]
  }
];
