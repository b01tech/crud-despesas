import { TestBed } from '@angular/core/testing';

import { DepesaService } from './depesa.service';

describe('DepesaService', () => {
  let service: DepesaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DepesaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
