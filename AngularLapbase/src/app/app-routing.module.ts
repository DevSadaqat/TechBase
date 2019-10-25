import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { FullComponent } from './layouts/full/full.component';
import { BlankComponent } from './layouts/blank/blank.component';
import { AuthService } from './services/auth.service';

export const Approutes: Routes = [
  {
    path: 'login',
    redirectTo: '/authentication/login'
  },
  { path: '', redirectTo: '/authentication/login', pathMatch: 'full' },
  { path: 'authentication', loadChildren: './authentication/authentication.module#AuthenticationModule'},
    {path: '', component: FullComponent,
    
    children: [
      
      { path: 'apps', loadChildren: './apps/apps.module#AppsModule',
      canActivate:[AuthService]
    }
    ]
  },
  {
    path: '',
    component: BlankComponent,
    children: [
      {
        path: 'authentication',
        loadChildren:
          './authentication/authentication.module#AuthenticationModule'
      }
    ]
  },
  {
    path: '**',
    redirectTo: '/authentication/404'
  }
];
