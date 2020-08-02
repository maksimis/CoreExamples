import {Component, Input, OnInit} from '@angular/core';
import {IProject} from '../models/IProject';

@Component({
  selector: 'app-project',
  template: `
    <h2>
      {{project.name}}
    </h2>
    <p>
      {{project.description}}
    </p>
  `,
  styles: []
})
export class ProjectComponent implements OnInit {

  @Input()
  project: IProject;


  constructor() { }

  ngOnInit() {
  }

}
