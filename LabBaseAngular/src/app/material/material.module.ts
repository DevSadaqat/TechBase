import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import * as Material from "@angular/material";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    Material.MatToolbarModule,
    Material.MatButtonModule,
    Material.MatCheckboxModule,
    Material.MatCardModule,
    Material.MatInputModule,
    Material.MatCardModule,
    Material.MatBadgeModule,
    Material.MatToolbarModule,
    BrowserAnimationsModule,
  ]
})
export class MaterialModule { }
