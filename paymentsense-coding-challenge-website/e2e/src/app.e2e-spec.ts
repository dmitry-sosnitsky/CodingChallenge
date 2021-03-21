import { AppPage } from './app.po';
import { browser, logging } from 'protractor';

describe('workspace-project App', () => {
  let page: AppPage;

  beforeEach(() => {
    page = new AppPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getTitleText()).toEqual('Paymentsense Coding Challenge!');
  });

  it('should display Afghanistan in grid', () => {
    expect(page.getFirstCountryInGrid()).toEqual('Afghanistan');
  });

  it('should open Afghanistan details on click', () => {
    page.openFirstCountryDetailsDialog();
    expect(page.getCountryDetailsDialogTitle()).toEqual('Afghanistan');
  });  

  afterEach(async () => {
    // Assert that there are no errors emitted from the browser
    const logs = await browser.manage().logs().get(logging.Type.BROWSER);
    expect(logs).not.toContain(jasmine.objectContaining({
      level: logging.Level.SEVERE,
    } as logging.Entry));
  });
});
