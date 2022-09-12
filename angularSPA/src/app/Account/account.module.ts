import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AccountRoutingModule } from './account-routing.module';
import { LoginComponent } from '../Account/login.component';
import { RegisterComponent } from '../Account/register.component';
import { CreateMovieComponent } from '../Account/create-movie.component';
import { CreateCastComponent } from '../Account/create-cast.component';
import { TopPurchasesComponent } from '../Account/top-purchases.component';
import { PurchasesComponent } from '../User/purchases.component';
import { FavoritesComponent } from '../User/favorites.component';
import { ReviewsComponent } from '../User/reviews.component';
import { EditProfileComponent } from '../User/edit-profile.component';


@NgModule({
  declarations: [
    LoginComponent,
    RegisterComponent,
    CreateMovieComponent,
    CreateCastComponent,
    TopPurchasesComponent,
    PurchasesComponent,
    FavoritesComponent,
    ReviewsComponent,
    EditProfileComponent
  ],
  imports: [
    CommonModule,
    AccountRoutingModule
  ]
})
export class AccountModule { }
