import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { AddGenreComponent } from './add-genre.component';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { CreateCastComponent } from './create-cast.component';
import { TopPurchasesComponent } from './top-purchases.component';


@NgModule({
  declarations: [
    AddGenreComponent, 
    CreateCastComponent, 
    CreateCastComponent, 
    TopPurchasesComponent
  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class AdminModule { }
