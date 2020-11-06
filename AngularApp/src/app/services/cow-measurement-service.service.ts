import { Injectable, OnInit } from '@angular/core';

import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';

import { catchError, map, tap } from 'rxjs/operators';

import { BaseService } from './base-service.service';

import { CowMeasurement } from '../models/cowmeasurement';

import { AppConfig } from '../config/config';

@Injectable()

export class CowMeasurementService extends BaseService {

  private pathAPI = this.config.setting['PathBackEndAPI'];

  constructor(private http: HttpClient, private config: AppConfig) { super(); }

    getCowMeasurements(): Observable<CowMeasurement[]> {

    return this.http.get<CowMeasurement[]>(this.pathAPI + 'GetAllMeasurements', super.header()).pipe(

    catchError(super.handleError));
    }

  }
export class TableDemo implements OnInit {

    measurements: CowMeasurement[];

    constructor(private cowMeasurementService: CowMeasurementService) { }

    ngOnInit() {
        this.cowMeasurementService.getCowMeasurements().subscribe((data) => this.measurements = data);
    }
}
