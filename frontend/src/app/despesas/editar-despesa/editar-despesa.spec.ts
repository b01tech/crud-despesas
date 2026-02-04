import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarDespesa } from './editar-despesa';

describe('EditarDespesa', () => {
  let component: EditarDespesa;
  let fixture: ComponentFixture<EditarDespesa>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditarDespesa]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditarDespesa);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
