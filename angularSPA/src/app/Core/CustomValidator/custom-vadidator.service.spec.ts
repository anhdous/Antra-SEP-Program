import { TestBed } from '@angular/core/testing';

import { CustomValidatorService } from './custom-vadidator.service';

describe('CustomVadidatorService', () => {
  let service: CustomValidatorService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CustomValidatorService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
