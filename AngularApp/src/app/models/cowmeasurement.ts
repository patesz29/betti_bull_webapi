import { Guid } from 'guid-typescript';

export class CowMeasurement {
    id: Guid;
    CowId: string;
    MeasurementType: number;
    MeasurementDate: Date;
    Bcs: number;
    Lesion: string;
    UterusStatus: number;
    CervixDiameter: number;
    HornDiameter: number;
    RightOvaryState: number;
    LeftOvaryState: number;
    CitologyResultCervix: number;
    CitologyResultEndometrium: number;
    Nefa: number;
    Bhb: number;
    BetaKarotin: number;
    QLazResult: number;
    PregnancyDetectionResult30Day: string;
    PregnancyDetectionResult60Day: string;
    FirstSuccessfulFertilizationDate: Date;
    SuccessfulFertilizationNumber: number;
 }
