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
    path: '/apps/demographic',
    title: 'Demographics',
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
    path: '/apps/report',
    title: 'Reports',
    icon: 'mdi mdi-file-document',
    class: '',
    extralink: false,
    submenu: []
  }
];
