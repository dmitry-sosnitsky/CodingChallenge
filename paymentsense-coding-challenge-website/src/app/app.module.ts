import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PaymentsenseCodingChallengeApiService } from './services';
import { HttpClientModule } from '@angular/common/http';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AgGridModule } from 'ag-grid-angular';
import { MatDialogModule } from '@angular/material/dialog';
import { ImageFormatterComponent } from "./components/ImageFormatterComponent";
import { CountrySummaryComponent } from './components/CountrySummaryComponent';

@NgModule({
  declarations: [
    AppComponent,
    ImageFormatterComponent,
    CountrySummaryComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FontAwesomeModule,
    MatDialogModule,
    AgGridModule.withComponents([ImageFormatterComponent])
  ],
  providers: [PaymentsenseCodingChallengeApiService],
  entryComponents: [CountrySummaryComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
