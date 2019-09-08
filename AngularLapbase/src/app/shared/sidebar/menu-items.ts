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
    path: '/apps/dashboard',
    title: 'Dashboard',
    icon: 'mdi mdi-view-dashboard',
    class: '',
    extralink: false,
    submenu: []
  },
  {
    path: '/apps/demographicdetails',
    title: 'My Demographics',
    icon: 'mdi mdi-account-circle',
    class: '',
    extralink: false,
    submenu: []
  },
  {
    path: '/apps/food',
    title: 'Food',
    icon: 'mdi mdi-food',
    class: '',
    extralink: false,
    submenu: []
  },
  {
    path: '/apps/exercise',
    title: 'Exercise',
    icon: 'mdi mdi-run',
    class: '',
    extralink: false,
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
        path: '/apps/bmi',
        title: 'BMI',
        icon: 'mdi mdi-chart-pie',
        class: '',
        extralink: false,
        submenu: []
      },
      {
        path: '/apps/weight',
        title: 'Weight',
        icon: 'mdi mdi-chart-bar',
        class: '',
        extralink: false,
        submenu: []
      }, 
    ]
  }
];
