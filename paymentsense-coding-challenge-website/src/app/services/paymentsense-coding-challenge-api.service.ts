import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { ICountryDetailsModel } from '../models/ICountryDetailsModel';

@Injectable({
  providedIn: 'root'
})
export class PaymentsenseCodingChallengeApiService {
  constructor(private httpClient: HttpClient) {}

  public getCountries(): Observable<ICountryDetailsModel[]> {
    return this.httpClient.get<ICountryDetailsModel[]>('https://localhost:44341/countries');
  }
}
