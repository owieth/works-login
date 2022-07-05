import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { FilmService } from '../film.service';
import { Film } from '../film';

@Component({
  selector: 'app-detail',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.css']
})
export class DetailComponent implements OnInit {
  film: Film;


  constructor(private filmService: FilmService, private route: ActivatedRoute) { }

  ngOnInit(): void {
      this.getFilm();
  }

  getFilm(): void {
    const id = +this.route.snapshot.paramMap.get('id');
    this.filmService.getFilm(id).subscribe(film => this.film = film);
  }

  message(): void {
    const answer = confirm("Wollen Sie diesen Film löschen?");
  }

  deleteFilm(): void {
    const id = +this.route.snapshot.paramMap.get('id');
    this.filmService.deleteFilm(id).subscribe(film => this.film = film);
  }
}
