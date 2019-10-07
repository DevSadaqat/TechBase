import { Routes } from '@angular/router';

import { DemographicComponent } from './demographic/demographic.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FoodComponent } from './food/food.component';
import { ExerciseComponent } from './exercise/exercise.component';
import { ReportComponent } from './report/report.component';


export const AppsRoutes: Routes = [
  {
    path: '',
    children: [

      { path: 'dashboard',
        component: DashboardComponent,
        data: { title: 'Dashboard', urls: [{ title: 'Dashboard', url: '/apps/dashboard' }, { title: 'Dashboard' }] } 
      },
      {
        path: 'demographic',
        component: DemographicComponent,
        data: { title: 'Demographic', urls: [{ title: 'Dashboard', url: '/apps/dashboard' }, { title: 'Demographic' }] }
      },
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
      {
        path: 'report',
        component: ReportComponent,
        data: { title: 'Report', urls: [{ title: 'Dashboard', url: '/apps/dashboard' }, { title: 'Report' }] }
      }
    ]
  }
];
