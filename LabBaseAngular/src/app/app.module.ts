import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { DemographicComponent } from './demographic/demographic.component';
import { FoodComponent } from './food/food.component';
import { ExcerciseComponent } from './excercise/excercise.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    DemographicComponent,
    FoodComponent,
    ExcerciseComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
