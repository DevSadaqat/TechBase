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
      data: { title: 'Exercise Log', urls: [ { title: 'Dashboard', url: '/dashboard' }, { title: 'Exercise Log' } ] } },
      
      { path: 'foodlog', component: FoodlogComponent,
        data: { title: 'Food Log', urls: [ { title: 'Dashboard', url: '/dashboard' }, { title: 'Food Log' } ] } },
      
      { path: 'addfood', component: AddfoodComponent,
        data: { title: 'Add Food', urls: [ { title: 'Dashboard', url: '/dashboard' }, { title: 'Add Food' } ] } },
      
     /* { path: 'demographic', component: DemographicComponent, 
      data: { title: 'My Demographics', urls: [ { title: 'Dashboard', url: '/dashboard' }, { title: 'My Demographics' } ] } },*/

      { path: 'demographicdetails', component: DemographicdetailsComponent, 
      data: { title: 'My Demographics', urls: [ { title: 'Dashboard', url: '/dashboard' }, { title: 'My Demographics' } ] } },
 
      { path: 'weight', component: WeightComponent,
        data: { title: 'Add Weight', urls: [ { title: 'Weight', url: '/weight' }, { title: 'Add Weight' } ] } },

      { path: 'addexercise', component: AddexerciseComponent,
        data: { title: 'Add Exercise Duration', urls: [ { title: 'Dashboard', url: '/dashboard' }, { title: 'Add Exercise Duration' } ] } }
    ]
  }
];
