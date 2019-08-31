import { TestBed } from '@angular/core/testing';

import { ExcerciseService } from './excercise.service';

describe('ExcerciseService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ExcerciseService = TestBed.get(ExcerciseService);
    expect(service).toBeTruthy();
  });
});
