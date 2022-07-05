import { Component, OnInit } from '@angular/core';
import { FilmService } from '../film.service';
import { Film } from '../film';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-ubersicht',
  templateUrl: './ubersicht.component.html',
  styleUrls: ['./ubersicht.component.css']
})
export class UbersichtComponent implements OnInit {
  filme: Film[];

  constructor(private filmService: FilmService) { }

  ngOnInit() {
    this.getFilme();
  }

  getFilme(): void {
    this.filmService.getFilme()
      .subscribe(filme => this.filme = filme);
  }
}
