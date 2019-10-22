import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-report',
  templateUrl: './report.component.html',
  styleUrls: ['./report.component.css']
})
export class ReportComponent implements OnInit {
  currentJustify ="justified";


  constructor() { }

  //BMI Chart
  public bmiChartData: Array<any> = [
    { data: [65, 39, 80, 15, 76, 35, 40, 98, 57, 58, 86, 57], label: 'BMI' }
    
  ];

  public bmiChartLabels: Array<any> = [
    'January',
    'February',
    'March',
    'April',
    'May',
    'June',
    'July',
    'August',
    'September',
    'October',
    'November',
    'December'
  ];

  public bmiChartOptions: any = {
    responsive: true
  };

  public bmiChartColors: Array<any> = [
    {
      
      backgroundColor: 'rgba(54,190,166,.1)',
      borderColor: '#2962ff',
      pointBackgroundColor: '#2962ff	',
      pointBorderColor: '#fff',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: '#2962ff'
    }
  ];
  
  public bmiChartLegend = true;
  public bmiChartType = 'line';


  //Calorie Chart  
  public lineChartData: Array<any> = [
    { data: [65, 39, 80, 15, 76, 35, 40, 98, 657, 258, 286, 657], label: 'Intake' },
    { data: [200, 59, 27, 90, 67, 57, 15, 12, 65, 25, 84, 65], label: 'Burnt' }
    
  ];

  public lineChartLabels: Array<any> = [
    'January',
    'February',
    'March',
    'April',
    'May',
    'June',
    'July',
    'August',
    'September',
    'October',
    'November',
    'December'
  ];

  public lineChartOptions: any = {
    responsive: true
  };

  public lineChartColors: Array<any> = [
    {
      
      backgroundColor: 'rgba(54,190,166,.1)',
      borderColor: '#2962ff',
      pointBackgroundColor: '#2962ff	',
      pointBorderColor: '#fff',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: '#2962ff'
    },
    {
    
      backgroundColor: 'rgb(41,98,255,.1)',
      borderColor: '	#FF6347',
      pointBackgroundColor: '	#FF6347',
      pointBorderColor: '#fff',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: '#FF6347	'
    }
  ];
  
  public lineChartLegend = true;
  public lineChartType = 'line';


    //Weight Chart  
    public weightChartData: Array<any> = [
     { data: [200, 59, 27, 90, 67, 57, 15, 12, 65, 25, 84, 65], label: 'TWL' },
     { data: [200, 95, 72, 65, 76, 75, 51, 21, 56, 52, 48, 56], label: 'EWL' }
      
    ];
  
    public weightChartLabels: Array<any> = [
      'January',
      'February',
      'March',
      'April',
      'May',
      'June',
      'July',
      'August',
      'September',
      'October',
      'November',
      'December'
    ];
  
    public weightChartOptions: any = {
      responsive: true
    };
  
    public weightChartColors: Array<any> = [
      {
      
        backgroundColor: 'rgba(54,190,166,.1)',
        borderColor: '#2962ff',
        pointBackgroundColor: '#2962ff	',
        pointBorderColor: '#fff',
        pointHoverBackgroundColor: '#fff',
        pointHoverBorderColor: '#2962ff'
      },
      {
    
        backgroundColor: 'rgb(41,98,255,.1)',
        borderColor: '	#FF6347',
        pointBackgroundColor: '	#FF6347',
        pointBorderColor: '#fff',
        pointHoverBackgroundColor: '#fff',
        pointHoverBorderColor: '#FF6347	'
      }
    ];
    
    public weightChartLegend = true;
    public weightChartType = 'line';

  ngOnInit() {
  }

}
