import { Routes } from '@angular/router';

import { ExerciselogComponent } from './exerciselog/exerciselog.component';
import { FoodlogComponent } from './foodlog/foodlog.component';
import { AddfoodComponent } from './addfood/addfood.component';
import { DemographicComponent } from './demographic/demographic.component';
import { AddexerciseComponent } from './addexercise/addexercise.component';

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
      
      { path: 'demographic', component: DemographicComponent, 
      data: { title: 'My Demographics', urls: [ { title: 'Dashboard', url: '/dashboard' }, { title: 'My Demographics' } ] } },
      
      { path: 'addexercise', component: AddexerciseComponent,
        data: { title: 'Add Exercise Duration', urls: [ { title: 'Dashboard', url: '/dashboard' }, { title: 'Add Exercise Duration' } ] } }
    ]
  }
];
