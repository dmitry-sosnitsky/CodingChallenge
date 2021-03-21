import { Component } from '@angular/core';
import { PaymentsenseCodingChallengeApiService } from './services';
import { take } from 'rxjs/operators';
import { ICountryDetailsModel } from './models/ICountryDetailsModel';
import { ImageFormatterComponent } from "./components/ImageFormatterComponent";
import { MatDialog } from '@angular/material/dialog';
import { CountrySummaryComponent } from './components/CountrySummaryComponent';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  
  public title = 'Paymentsense Coding Challenge!';
  public rowClass = 'grid-row';  

  onRowClicked(event: any) { 
    this.dialog.open(CountrySummaryComponent, { data: event.data })
  }

  public rowData: ICountryDetailsModel[] = [];
  public pagination: boolean = true;

  public columnDefs = [
    {headerName: 'Name', field: 'name'},
    {headerName: 'Flag', field: 'flagImage', cellRendererFramework: ImageFormatterComponent}
  ];

  constructor(private paymentsenseCodingChallengeApiService: PaymentsenseCodingChallengeApiService, public dialog: MatDialog) {
    this.dialog = dialog;

    paymentsenseCodingChallengeApiService.getCountries().pipe(take(1))
    .subscribe(
      countries => {
        this.rowData = countries;
      },
      _ => {
        alert('error');
      });
  }
}
