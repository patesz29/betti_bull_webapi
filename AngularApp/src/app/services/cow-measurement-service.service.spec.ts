import { TestBed } from '@angular/core/testing';

import { CowMeasurementService } from './cow-measurement-service.service';

describe('CowMeasurementServiceService', () => {
  let service: CowMeasurementService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CowMeasurementService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
