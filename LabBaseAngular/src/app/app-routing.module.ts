import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DemographicComponent } from './demographic/demographic.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ExcerciseComponent } from './excercise/excercise.component';
import { FoodComponent } from './food/food.component';
import { WeightComponent } from './weight/weight.component';
import { SidenavComponent } from './sidenav/sidenav.component';
import { LoginComponent } from './login/login.component';
import { NotFoundComponent } from './not-found/not-found.component';


const routes: Routes = [
  { path: 'login', component: LoginComponent},
  { path: 'sidenav', component: SidenavComponent},
  { path: 'demographics', component: DemographicComponent},
  { path: 'dashboard', component: DashboardComponent},
  { path: 'exercise', component: ExcerciseComponent},
  { path: 'food', component: FoodComponent},
  { path: 'weight', component: WeightComponent},
  {path: '**', component: NotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [DemographicComponent, DashboardComponent, ExcerciseComponent, FoodComponent, WeightComponent, SidenavComponent, LoginComponent]
