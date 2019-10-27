import { Component, AfterViewInit } from '@angular/core';
import {PatientService} from '../../services/patient.service';
import {Patient} from '../../models/Patient';
import { NgbModal, ModalDismissReasons, NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-demographic',
  templateUrl: './demographic.component.html',
  styles: [
    `
      .dark-modal .modal-content {
        background-color: #009efb;
        color: white;
      }
      .dark-modal .close {
        color: white;
      }
      .light-blue-backdrop {
        background-color: #5cb3fd;
      }
    `
  ]
})
export class DemographicComponent implements AfterViewInit {
  currentJustify ="justified";
  closeResult: string;
  patID: string;
  orgCode: string;
  patient: Patient = {
    PatientID: "",
    OrganizationCode: "",
    Title: "",
    Surname:"",
    FirstName: "",
    BirthDate: "",
    Gender:  "",
    Height:  "",
    PhoneNumber:  "",
    Mobile:  "",
    ContactEmail:  "",
    Street:  "",
    Suburb:  "",
    City:  "",
    State:  "",
    PinCode:  "",
    Country:  "",
    Insurance: "",
    InsuranceEmployer:  "",
    InusuranceNumber:  "",
    MedicareNumber:  ""
  };
  constructor(private pat_Serv: PatientService, private modalService: NgbModal, private modalService2: NgbModal) { }
ngAfterViewInit() {

  this.patID  = localStorage.getItem("patientID");
  this.orgCode = localStorage.getItem("organizationCode");

   return this.pat_Serv.getPatientById(this.patID,this.orgCode).subscribe(data =>
    {        
      //window.alert(1)
      this.patient = data[0];
      console.log(this.patient);
      //localStorage.setItem("FirstName", this.patient.F);
      localStorage.setItem("Height", data.Height);
     //console.log(this.patient)
    }); 
 }

  open(content) {
    this.modalService2.open(content, { windowClass: 'dark-modal' });
  }
  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }

  open2(content) {
    this.modalService.open(content).result.then(
      result => {
        this.closeResult = `Closed with: ${result}`;
      },
      reason => {
        this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
      }
    );
  }

  openLg(content) {
    this.modalService.open(content, { size: 'lg' });
  }
}