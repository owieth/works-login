import { Component, OnInit, Input } from '@angular/core';
import { Location } from '@angular/common';

import { Film } from '../film';
import { FilmService } from '../film.service';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {

  filme: Film[];

  @Input() film: Film;

  constructor(private filmService: FilmService, private location: Location) { }

  ngOnInit() {
  }


  save(): void {
    this.filmService.updateFilm(this.film)
      .subscribe(() => this.goBack());
  }

  goBack(): void {
    this.location.back();
  }


}
