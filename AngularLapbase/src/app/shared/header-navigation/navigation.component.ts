import { Component, AfterViewInit } from '@angular/core';
import {PatientService} from '../../services/patient.service';
import {Router} from '@angular/router';
import {Patient} from '../../models/Patient';
import {
  NgbModal,
  ModalDismissReasons,
  NgbPanelChangeEvent,
  NgbCarouselConfig
} from '@ng-bootstrap/ng-bootstrap';
import { PerfectScrollbarConfigInterface } from 'ngx-perfect-scrollbar';
declare var $: any;

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html'
})
export class NavigationComponent implements AfterViewInit {
  public config: PerfectScrollbarConfigInterface = {};
  patID: string;
  orgCode: string;
  username:string;
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
  public showSearch = false;

  constructor(private modalService: NgbModal,
    private router: Router,
    private pat_Serv: PatientService
    ) { }

  // This is for Notifications
  notifications: Object[] = [
    {
      btn: 'btn-success',
      icon: 'ti-calendar',
      title: 'Visit tomorrow',
      subject: 'Appointment with Dr',
      time: '9:10 AM'
    },
    {
      btn: 'btn-primary',
      icon: 'ti-user',
      title: 'Subscription',
      subject: 'Renew Subscription!',
      time: '9:00 AM'
    }
  ];

  logout()
  {
    localStorage.clear();
    this.router.navigate(['../authentication/login']);
  }


  ngAfterViewInit() {
    this.patID  = localStorage.getItem("patientID");
    this.orgCode = localStorage.getItem("organizationCode");
    this.username = localStorage.getItem("username");
    
    this.pat_Serv.getPatientById(this.patID,this.orgCode).subscribe(data =>
    {
      this.patient = data[0];
    });
   }
}
