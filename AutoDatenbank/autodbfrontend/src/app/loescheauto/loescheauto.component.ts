import { Component, OnInit } from '@angular/core';
import { Auto } from "../autos";
import { AutoService } from "../auto.service";

@Component({
  selector: 'app-loescheauto',
  templateUrl: './loescheauto.component.html',
  styleUrls: ['./loescheauto.component.css']
})
export class LoescheautoComponent implements OnInit {
  autos: Auto[];
  constructor(private autoService: AutoService) { }

  ngOnInit() {
  }

  delete(auto: Auto): void {
    this.autos = this.autos.filter(h => h !== auto);
    this.autoService.deleteAuto(auto).subscribe();
  }
}
