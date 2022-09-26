import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddGenreComponent } from './add-genre.component';
import { CreateCastComponent } from './create-cast.component';
import { CreateMovieComponent } from './create-movie.component';
import { TopPurchasesComponent } from './top-purchases.component';

const routes: Routes = [
  { path: "Create-Cast", component:CreateCastComponent},
  { path: "Create-Movie", component:CreateMovieComponent},
  { path: "Top-Purchases", component:TopPurchasesComponent},
  { path: "Add-Genre", component:AddGenreComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
