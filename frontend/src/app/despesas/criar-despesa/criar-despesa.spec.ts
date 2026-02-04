import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CriarDespesa } from './criar-despesa';

describe('CriarDespesa', () => {
  let component: CriarDespesa;
  let fixture: ComponentFixture<CriarDespesa>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CriarDespesa]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CriarDespesa);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
