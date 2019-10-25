import { TestBed } from '@angular/core/testing';
import { Users } from '../models/User';
import { AuthService } from './auth.service';
import { Observable } from 'rxjs';

describe('AuthService', () => {

  let usersService: AuthService; // Add this

  beforeEach(() => TestBed.configureTestingModule({
    providers: [AuthService]
  }));

  it('should be created', () => {
    const service: AuthService = TestBed.get(AuthService);
    expect(service).toBeTruthy();
    usersService = TestBed.get(AuthService);
  });

  describe('authorizedUser', () => {
    it('should return a single user', () => {
      const userResponse = {
      IsSuccess: 'true',
      OrganizationCode: "2",
      PatientID: "27",
      UserId: "TechInnovators"}
      let response;
      //spyOn(usersService, 'loginUserDetails').and.returnValue((userResponse));
  
      usersService.authorizedUser('true').subscribe(res => {
        response = res;
      });
  
      expect(response).toEqual(userResponse);
    });
  });
});
