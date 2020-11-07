import { Component, OnInit } from '@angular/core';
import { CowMeasurement } from 'src/app/models/cowmeasurement';
import { CowMeasurementService } from 'src/app/services/cow-measurement-service.service';


@Component({
  selector: 'app-cow-measurements',
  templateUrl: './cow-measurements.component.html',
  styleUrls: ['./cow-measurements.component.scss']
})
export class CowMeasurementsComponent implements OnInit {
  displayedColumns: string[] = [
    'id',
    'cowId',
    'measurementType',
    'bcs',
    'lesion',
    'uterusStatus',
    'cervixDiameter',
    'hornDiameter',
    'rightOvaryState',
    'leftOvaryState',
    'citologyResultCervix',
    'citologyResultEndometrium',
    'nefa',
    'bhb',
    'betaKarotin',
    'qLazResult',
    'pregnancyDetectionResult30Day',
    'pregnancyDetectionResult60Day',
    'successfulFertilizationNumber'
  ];
  dataSource = [];

  constructor(private cowservice: CowMeasurementService) { }
  ngOnInit(): void {
    this.cowservice.getCowMeasurements().subscribe((res: CowMeasurement[]) => {
      this.dataSource = res;
    });
  }



}
