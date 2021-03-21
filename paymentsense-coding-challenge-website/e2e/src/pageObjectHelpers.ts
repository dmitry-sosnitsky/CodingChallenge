import {browser, by, element, Locator, protractor, $} from "protractor";
import {IWebElement} from "selenium-webdriver";

export interface IPageObjectHelpers {
    goToPage(pageUrl: string);
    waitForElement(selector: Locator);
    getText(selector: Locator);
    clickElement(selector: Locator);
}

class PageObjectHelpers implements IPageObjectHelpers {
    static DEFAULT_TIMEOUT = 180000;

    public goToPage(pageUrl: string) {
        return browser.get(pageUrl);
    }

    public waitForElement(selector: Locator) {
        return browser.wait(() =>  browser.isElementPresent(selector), PageObjectHelpers.DEFAULT_TIMEOUT);
    }

    public clickElement(selector: Locator) {
        return element.all(selector).first().click();
    }

    public getText(selector: Locator){
        return element(selector).getText();
    }
}

module.exports = new PageObjectHelpers();