import { Component, OnInit, AfterViewInit } from '@angular/core';
import {WeightList} from '../../models/weightList';
import {BmiList} from '../../models/bmiList';
import {Chart} from 'chart.js'
import { WeightService } from '../../services/weight.service';
import * as moment from 'moment';

@Component({
  selector: 'app-report',
  templateUrl: './report.component.html',
  styleUrls: ['./report.component.css']
})
export class ReportComponent implements AfterViewInit {
  currentJustify ="justified";
  patID: string;
  orgCode: string;

  //for weight graph
  weightGraph: WeightList[];
  weightNum: number[]= [];
  DateG:string[]=[];
  Weightchart:any = [];

  //for BMI Graph 
  bmiNum: number[] = [];
  bmidate: string[]=[];
  Bmichart: any = [];

  constructor(private weightService: WeightService) { }

  
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
    

  ngAfterViewInit() {
    this.patID  = localStorage.getItem("patientID");
    this.orgCode = localStorage.getItem("organizationCode");  

        //method to call list of all weights to display on graph 
        this.weightService.getAllWeights(this.patID,this.orgCode).subscribe((res: WeightList[]) =>
        {
        res.forEach(x => {
          let myDate:string = moment(x.dateAdded,"YYYY-MM-DD").format("DD-MM-YYYY");
            this.weightNum.push(+x.weight);
            this.DateG.push(myDate);
            //console.log("1");
           // console.log(this.weightNum);
           // console.log("1");
        // console.log(x.dateAdded);
          });
          console.log(res);
          this.Weightchart = new Chart('canvas', {
            type: 'line',
            data: {
              labels: this.DateG,
              datasets: [
                {
                  data : this.weightNum,
                 
                  backgroundColor: 'rgba(54,190,166,.1)',
                  borderColor: '#2962ff',
                  pointBackgroundColor: '#2962ff	',
                  pointBorderColor: '#fff',
                  pointHoverBackgroundColor: '#fff',
                  pointHoverBorderColor: '#2962ff'
             
                }
              ]
            },
            options: {
              legend: {
                display: false
              },
              scales: {
                xAxes: [{
                  display: true
                }],
                yAxes: [{
                  display: true
                }],
              }
            }
          });
        });

            //method to call BMIs to display on Graph
      this.weightService.getBmiForGraph(this.patID,this.orgCode).subscribe((res: BmiList[]) =>
      {
      // console.log(res);
      res.forEach(x => {
        let myDate:string = moment(x.dateAdded,"YYYY-MM-DD").format("DD-MM-YYYY");
          this.bmiNum.push(+x.BMI.toFixed(1));
          this.bmidate.push(myDate);
          // console.log(this.bmiNum);
          // console.log(this.bmidate);

        });
        console.log(res);
        this.Bmichart = new Chart('BMIcanvas', {
          type: 'line',
          data: {
            labels: this.bmidate,
            datasets: [
              {
                data : this.bmiNum,
               
                backgroundColor: 'rgba(54,190,166,.1)',
                borderColor: '#2962ff',
                pointBackgroundColor: '#2962ff	',
                pointBorderColor: '#fff',
                pointHoverBackgroundColor: '#fff',
                pointHoverBorderColor: '#2962ff'
                // borderColor: '#3cb371',
                // backgroundColor: "#0000FF",
              }
            ]
          } ,
          options: {
            legend: {
              display: false
            },
            scales: {
              xAxes: [{
                display: true
              }],
              yAxes: [{
                display: true
              }],
            }
          }
        });
      });

  


  }

}
