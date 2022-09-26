import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserRoutingModule } from './user-routing.module';
import { ReviewsComponent } from './reviews.component';
import { EditProfileComponent } from './edit-profile.component';
import { PurchasesComponent } from './purchases.component';
import { FavoritesComponent } from './favorites.component';


@NgModule({
  declarations: [
    PurchasesComponent,
    FavoritesComponent,
    ReviewsComponent,
    EditProfileComponent
  ],
  imports: [
    CommonModule,
    UserRoutingModule, 

  ]
})
export class UserModule { }
