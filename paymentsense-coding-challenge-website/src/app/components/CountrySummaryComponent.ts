import { Component, Inject } from "@angular/core";
import { MAT_DIALOG_DATA} from '@angular/material/dialog';
import { ICountryDetailsModel } from '../models/ICountryDetailsModel';

@Component({
    selector: 'country-summary-component',
    templateUrl: 'country-summary.html',
  })
  export class CountrySummaryComponent {
    constructor(@Inject(MAT_DIALOG_DATA) public data: ICountryDetailsModel) {
    }
  }