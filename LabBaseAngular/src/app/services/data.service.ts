import { Injectable } from '@angular/core';
@Injectable()
/*@Injectable({
  providedIn: 'root'
})*/
export class DataService {
  public patientid:string;
  public organizationCode:string;

  constructor() { 
    this.patientid = "";
    this.organizationCode= "";
  }
  setPatientID (data) {
    this.patientid = data;
  }
  getPatientID () {
    return this.patientid;
  }
  setOrganizationCode (data) {
    this.organizationCode = data;
  }
  getOrganizationCode () {
    return this.organizationCode;
  }
}
