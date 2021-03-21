import { Component } from "@angular/core";

@Component({
  selector: 'app-image-formatter-cell',
  template: `<img border="0" height="25" src=\"{{ params.value }}\">` })

export class ImageFormatterComponent {
  params: any;
  agInit(params: any){
    this.params = params; 
  } 
}