import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CowMeasurementsComponent } from './cow-measurements.component';

describe('CowMeasurementsComponent', () => {
  let component: CowMeasurementsComponent;
  let fixture: ComponentFixture<CowMeasurementsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CowMeasurementsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CowMeasurementsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
