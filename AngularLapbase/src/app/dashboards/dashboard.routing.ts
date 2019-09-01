import { Routes } from '@angular/router';

import { Dashboard1Component } from './dashboard1/dashboard1.component';


export const DashboardRoutes: Routes = [
{ path: '', children: [ 
  { path: 'classic', component: Dashboard1Component, data: { title: 'Dashboard', urls: [ 
    { title: 'Dashboard', url: '/dashboard' }, { title: ' Dashboard' }
            ] 
          }
       },
    ]
  }
];
