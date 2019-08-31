import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { FullComponent } from './layouts/full/full.component';
import { BlankComponent } from './layouts/blank/blank.component';

export const Approutes: Routes = [
  {
    path: 'login',
    redirectTo: '/authentication/login'
  },
  { path: '', redirectTo: '/authentication/login', pathMatch: 'full' },
  {path: 'authentication', loadChildren: './authentication/authentication.module#AuthenticationModule'},
    {path: '', component: FullComponent,
    children: [
      
      
      { path: 'dashboard', loadChildren: './dashboards/dashboard.module#DashboardModule'},
      { path: 'apps', loadChildren: './apps/apps.module#AppsModule' },
      { path: 'component', loadChildren: './component/component.module#ComponentsModule' },
      /*{ path: 'cards', loadChildren: './cards/cards.module#CardsModule' },
      /*{ path: 'starter', loadChildren: './starter/starter.module#StarterModule'},
      { path: 'icons', loadChildren: './icons/icons.module#IconsModule' },
      { path: 'forms', loadChildren: './form/forms.module#FormModule' },
      { path: 'tables', loadChildren: './table/tables.module#TablesModule' },
      { path: 'charts', loadChildren: './charts/charts.module#ChartModule' },
      { path: 'widgets', loadChildren: './widgets/widgets.module#WidgetsModule'},
      { path: 'ecom', loadChildren: './ecommerce/ecom.module#EcomModule' },
      { path: 'timeline', loadChildren: './timeline/timeline.module#TimelineModule'},
      { path: 'extra-component', loadChildren: './extra-component/extra-component.module#ExtraComponentModule' },*/
	    /*{ path: 'apps/email', loadChildren: './apps/email/mail.module#MailModule' },
      { path: 'maps', loadChildren: './maps/maps.module#MapsModule' },
      { path: 'sample-pages', loadChildren: './sample-pages/sample-pages.module#SamplePagesModule'}*/
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
