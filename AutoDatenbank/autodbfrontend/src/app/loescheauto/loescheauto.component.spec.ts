import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LoescheautoComponent } from './loescheauto.component';

describe('LoescheautoComponent', () => {
  let component: LoescheautoComponent;
  let fixture: ComponentFixture<LoescheautoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LoescheautoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LoescheautoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
