import { RouteInfo } from './sidebar.metadata';

export const ROUTES: RouteInfo[] = [
  {
    path: '',
    title: '',
    icon: '',
    class: 'nav-small-cap',
    extralink: true,
    submenu: []
  },
  {
    path: '/dashboard/classic',
    title: 'Dashboards',
    icon: 'mdi mdi-view-dashboard',
    class: '',
    extralink: false,
    submenu: [
      
    ]
  },
  
  {
    path: '/apps/demographic',
    title: 'My Demographics',
    icon: 'mdi mdi-account-circle',
    class: '',
    extralink: false,
    submenu: []
  },
  {
    path: '',
    title: 'Food',
    icon: 'mdi mdi-food',
    class: 'has-arrow',
    extralink: false,
    submenu: [
      {
        path: '/apps/foodlog',
        title: 'Food Log',
        icon: 'mdi mdi-view-list',
        class: '',
        extralink: false,
        submenu: []
      },
      {
        path: '/apps/addfood',
        title: 'Add Food',
        icon: 'mdi mdi-gamepad',
        class: '',
        extralink: false,
        submenu: []
      }
    ]
  },
  {
    path: '',
    title: 'Exercise',
    icon: 'mdi mdi-run',
    class: 'has-arrow',
    extralink: false,
    submenu: [
      {
        path: '/apps/exerciselog',
        title: 'Exercise Log',
        icon: 'mdi mdi-view-list',
        class: '',
        extralink: false,
        submenu: []
      },
      {
        path: '/apps/addexercise',
        title: 'Add duration',
        icon: 'mdi mdi-gamepad',
        class: '',
        extralink: false,
        submenu: []
      },
      
      
      
    ]
  },
  {
    path: '',
    title: '',
    icon: '',
    class: 'nav-small-cap',
    extralink: true,
    submenu: []
  },
  {
    path: '',
    title: 'My Graphs',
    icon: 'mdi mdi-chart-line',
    class: 'has-arrow',
    extralink: false,
    submenu: [
      {
        path: '/component/bmi',
        title: 'BMI',
        icon: 'mdi mdi-chart-pie',
        class: '',
        extralink: false,
        submenu: []
      },
      {
        path: '/component/calories',
        title: 'Calories',
        icon: 'mdi mdi-message-bulleted',
        class: '',
        extralink: false,
        submenu: []
      },
      {
        path: '/component/weight',
        title: 'Weight',
        icon: 'mdi mdi-chart-bar',
        class: '',
        extralink: false,
        submenu: []
      },
     
    ]
  }
];
