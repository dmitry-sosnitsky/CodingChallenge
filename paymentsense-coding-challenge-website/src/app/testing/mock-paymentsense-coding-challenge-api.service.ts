import { Injectable } from '@angular/core';
import { of, Observable } from 'rxjs';
import { ICountryDetailsModel } from '../models/ICountryDetailsModel';
import { IObjectWithName } from '../models/IObjectWithName';

@Injectable({
  providedIn: 'root'
})

class DummyCountry implements ICountryDetailsModel {
  name: string;
  flagImage: string;
  capitalCity: string;
  pupulation: number;
  borderingCountries: IObjectWithName[];
  languages: IObjectWithName[];
  timeZones: IObjectWithName[];
  currencies: IObjectWithName[];
}

export class MockPaymentsenseCodingChallengeApiService {

  public getCountries(): Observable<ICountryDetailsModel[]> {
    const dummyCountry = new DummyCountry();
    dummyCountry.name = 'Mock country';
    return of([dummyCountry]);
  }
}
