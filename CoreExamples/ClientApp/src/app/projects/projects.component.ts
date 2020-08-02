import {Component, OnInit} from '@angular/core';
import {IProject} from './models/IProject';

@Component({
  selector: 'app-projects-component',
  templateUrl: './projects.component.html'
})
export class ProjectsComponent implements OnInit {
  projects: IProject[] = [];

  ngOnInit(): void {
    this.projects = [{
      name: 'My first project',
      description: 'It was cool project'
    }];
  }

}
