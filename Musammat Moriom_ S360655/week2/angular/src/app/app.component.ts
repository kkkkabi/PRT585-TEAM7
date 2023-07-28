import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: '<h1>hello world!<H1>',
  styleUrls: ['./app.component.css'],
 imports: [
    Homecomponent,
  ]
})
export class AppComponent {
  title = 'Homes';
}

import {Homecomponent } from './home/home.component';