import { browser, by, element } from 'protractor';
import { IPageObjectHelpers } from './pageObjectHelpers';

export class AppPage {

  private pageTitle = by.css('app-root h1');
  private firstCellInGrid = by.className('ag-cell');
  private dialogTitle = by.className('mat-dialog-title');

  private pageActions: IPageObjectHelpers = require('./pageObjectHelpers');  

  navigateTo() {
    return browser.get(browser.baseUrl) as Promise<any>;
  }

  getTitleText() {
    return this.pageActions.getText(this.pageTitle);
  }

  getFirstCountryInGrid(){
    this.pageActions.waitForElement(this.firstCellInGrid);
    return this.pageActions.getText(this.firstCellInGrid);
  }

  openFirstCountryDetailsDialog(){
    this.pageActions.clickElement(this.firstCellInGrid);
    this.pageActions.waitForElement(this.dialogTitle);
  }

  getCountryDetailsDialogTitle(){
    return this.pageActions.getText(this.dialogTitle);
  }
}
