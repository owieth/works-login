import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { UbersichtComponent } from './ubersicht/ubersicht.component';
import { DetailComponent } from './detail/detail.component';
import { CreateComponent } from './create/create.component';
import { UpdateComponent } from './update/update.component';

const routes: Routes = [
  { path: '', redirectTo: '/übersicht', pathMatch: 'full' },
  { path: 'übersicht', component: UbersichtComponent},
  { path: 'detail/:id', component: DetailComponent },
  { path: 'neu', component: CreateComponent},
  { path: 'update/:id', component: UpdateComponent}
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule { }
