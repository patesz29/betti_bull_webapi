import {HttpClientModule} from '@angular/common/http';

import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CowMeasurementsComponent } from './components/cow-measurements/cow-measurements.component';
import { MatInputModule } from '@angular/material/input';

import { FormsModule } from '@angular/forms';

import { MatTableModule } from '@angular/material/table';
import { CowMeasurementService } from './services/cow-measurement-service.service';
import { AppConfig } from './config/config';



@NgModule({
  declarations: [
    AppComponent,
    CowMeasurementsComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatInputModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,
    MatTableModule
  ],
  providers: [
    CowMeasurementService,
    AppConfig
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
