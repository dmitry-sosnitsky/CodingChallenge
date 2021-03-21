import { IObjectWithName } from './IObjectWithName';

export interface ICountryDetailsModel {
    name: string;
    flagImage: string;
    capitalCity: string;
    pupulation: number;
    borderingCountries: IObjectWithName[];
    languages: IObjectWithName[];
    timeZones: IObjectWithName[];
    currencies: IObjectWithName[];
}