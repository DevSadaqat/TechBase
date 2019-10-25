import { Component, AfterViewInit } from '@angular/core';
import {Router} from '@angular/router';
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

  public showSearch = false;

  constructor(private modalService: NgbModal,
    private router: Router) { }

  // This is for Notifications
  notifications: Object[] = [
    {
      btn: 'btn-success',
      icon: 'ti-calendar',
      title: 'Event today',
      subject: 'Just a reminder that you have event',
      time: '9:10 AM'
    },
    {
      btn: 'btn-primary',
      icon: 'ti-user',
      title: 'Robert',
      subject: 'Just see the Doctor!',
      time: '9:00 AM'
    }
  ];

  logout()
  {
    localStorage.clear();
    this.router.navigate(['../authentication/login']);
  }


  ngAfterViewInit() { }
}
