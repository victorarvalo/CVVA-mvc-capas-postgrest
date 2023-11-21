import { TestBed } from '@angular/core/testing';

import { PersonalReferenceServiceService } from './personal-reference-service.service';

describe('PersonalReferenceServiceService', () => {
  let service: PersonalReferenceServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PersonalReferenceServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
