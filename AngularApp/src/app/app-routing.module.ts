import { NgModule } from '@angular/core';

import { RouterModule, Routes } from '@angular/router';

import { CowMeasurementsComponent } from './components/cow-measurements/cow-measurements.component';

const routes: Routes = [

  { path: '',   redirectTo: '/cows', pathMatch: 'full' },
  { path: 'cows', component: CowMeasurementsComponent },
  { path: '**', redirectTo: '/' }

];
@NgModule({

  imports: [ RouterModule.forRoot(routes) ],

  exports: [ RouterModule ]

})

export class AppRoutingModule {}
