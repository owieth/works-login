import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class DataService {

  url = 'http://localhost:4200';

  constructor(private http: HttpClient) { }

  getDataFromDataBase(){
    return this.http.get(`${this.url}/neu`)
  }

  getDataFromDataBaseByID(id) {
    return this.http.get(`${this.url}/neu/${id}`);
  }

  addDataToDataBase(title, responsible, description, severity) {
    const issue = {
      title: title,
      responsible: responsible,
      description: description,
      severity: severity
    };
    return this.http.post(`${this.url}/issues/add`, issue);
  }

  updateDataInDataBase(id, title, responsible, description, severity, status) {
    const issue = {
      title: title,
      responsible: responsible,
      description: description,
      severity: severity,
      status: status
    };
    return this.http.post(`${this.url}/issues/update/${id}`, issue);
  }

  deleteDataFromDataBase(id) {
    return this.http.get(`${this.url}/issues/delete/${id}`);
  }
}
