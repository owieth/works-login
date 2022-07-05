import {Injectable} from "@angular/core";
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {Observable, of} from "rxjs";
import {Film} from "./film";

const httpOptions = {
  headers: new HttpHeaders({"Content-Type": "application/json"})
};

@Injectable({
  providedIn: "root"
})
export class FilmService {

  private filmeUrl = "http://localhost:1337";  // URL to web api

  constructor(private http: HttpClient) {
  }

  getFilme(): Observable<Film[]> {
    return this.http.get<Film[]>(this.filmeUrl);
  }

  getFilm(id: number): Observable<Film> {
    const url = `${this.filmeUrl}/detail/${id}`;
    return this.http.get<Film>(url);
  }

  searchFilm(term: string): Observable<Film[]> {
    if (!term.trim()) {
      // if not search term, return empty hero array.
      return of([]);
    }
    return this.http.get<Film[]>(`${this.filmeUrl}/?name=${term}`);
  }

  addFilm(hero: Film): Observable<Film> {
    return this.http.post<Film>(this.filmeUrl, hero, httpOptions);
  }

  deleteFilm(film: Film | number): Observable<Film> {
    const id = typeof film === "number" ? film : film.id;
    const url = `${this.filmeUrl}/${id}`;
    return this.http.delete<Film>(url, httpOptions).pipe();
  }

  updateFilm(film: Film): Observable<any> {
    return this.http.put(this.filmeUrl, film, httpOptions);
  }
}
