import { Component, OnInit, AfterViewInit } from '@angular/core';
import {WeightList} from '../../models/weightList';
import {BmiList} from '../../models/bmiList';
import { FoodService } from '../../services/food.service';
import { ExcerciseService } from '../../services/excercise.service';
import {Chart} from 'chart.js'
import { WeightService } from '../../services/weight.service';
import * as moment from 'moment';
import { Calories } from 'src/app/models/Calories';
import { PatientService } from 'src/app/services/patient.service';
import {WeightLost } from '../../models/EWL';
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

  //for EWL graph
  ewl: number[] = [];
  ewlDate:  string[]=[];
  EWLChart: any = [];

    //for calories graph
    calories: number[] = [];
    calDate: string[]=[];
    CalorieChart: any = [];
    caloriesBurnt: number[] = [];

  constructor(private pat_Serv: PatientService,
               private weightService: WeightService,
              private foodService: FoodService,
              private exerciseService: ExcerciseService,) { }

  
  //BMI Chart
  public bmiChartData: Array<any> = [
    // { data: [65, 39, 80, 15, 76, 35, 40, 98, 57, 58, 86, 57], label: 'BMI' }
    
  ];

  public bmiChartLabels: Array<any> = [
    // 'January',
    // 'February',
    // 'March',
    // 'April',
    // 'May',
    // 'June',
    // 'July',
    // 'August',
    // 'September',
    // 'October',
    // 'November',
    // 'December'
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
         // let myDate:string = moment(x.dateAdded,"YYYY-MM-DD").format("DD-MM-YYYY");
         let myDate:string = moment(x.dateAdded,"YYYY-MM-DD").format("MMM-YYYY");
            this.weightNum.push(+x.weight);
            this.DateG.push(myDate);
            //console.log("1");
         
          });
          console.log(res);
          this.Weightchart = new Chart('canvas', {
            type: 'line',
            data: {
              labels: this.DateG,
              datasets: [
                {
                  data : this.weightNum,
                  backgroundColor: 'rgb(41,98,255,.1)',
                  borderColor: '	#FF6347',
                  pointBackgroundColor: '	#FF6347',
                  pointBorderColor: '#fff',
                  pointHoverBackgroundColor: '#fff',
                  pointHoverBorderColor: '#FF6347'
                /*  backgroundColor: 'rgba(54,190,166,.1)',
                  borderColor: '#2962ff',
                  pointBackgroundColor: '#2962ff	',
                  pointBorderColor: '#fff',
                  pointHoverBackgroundColor: '#fff',
                  pointHoverBorderColor: '#2962ff'
             */
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
       // let myDate:string = moment(x.dateAdded,"YYYY-MM-DD").format("DD-MM-YYYY");
       let myDate:string = moment(x.dateAdded,"YYYY-MM-DD").format("MMM-YYYY");
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
                backgroundColor: 'rgb(41,98,255,.1)',
                borderColor: '	#FF6347',
                pointBackgroundColor: '	#FF6347',
                pointBorderColor: '#fff',
                pointHoverBackgroundColor: '#fff',
                pointHoverBorderColor: '#FF6347'
               /* backgroundColor: 'rgba(54,190,166,.1)',
                borderColor: '#2962ff',
                pointBackgroundColor: '#2962ff	',
                pointBorderColor: '#fff',
                pointHoverBackgroundColor: '#fff',
                pointHoverBorderColor: '#2962ff'*/
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

       //method to display EWL of patient
    this.pat_Serv.getEWLData(this.patID,this.orgCode).subscribe((res: WeightLost[]) =>
    {
      console.log(res);
     res.forEach(x => {
       let myDate:string = moment(x.Date,"MM,YYYY").format("MMM-YYYY");
         this.ewl.push(+x.EWL);
         this.ewlDate.push(myDate);
       
       });
       this.EWLChart = new Chart('EWLcanvas', {
        type: 'line',
        data: {
           labels: this.ewlDate,
          datasets: [
            {
              data: this.ewl,
              label: "% EWL",
              borderColor: '#FF6347',
              backgroundColor: 'rgb(41,98,255,.1)'
            }
          ]
        },
        options: {
          legend: {
            display: true
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
      //method display list of all burnt consumed 
   this.exerciseService.CaloriesBurnt(this.patID,this.orgCode).subscribe((res: Calories[]) =>
   {
     console.log(res);
    res.forEach(x => {
      let myDate:string = moment(x.date,"YYYY-MM-DD").format("DD-MM-YYYY");
    // let myDate:string = moment(x.date,"YYYY-MM-DD").format("MMM-YYYY");
        this.caloriesBurnt.push(+x.calories);
      //  this.calDate.push(myDate);
      });
    
    });
      

   //method display list of all calories consumed 
   this.foodService.CaloriesConsumed(this.patID,this.orgCode).subscribe((res: Calories[]) =>
   {
     console.log(res);
    res.forEach(x => {
      let myDate:string = moment(x.date,"YYYY-MM-DD").format("DD-MM-YYYY");
    // let myDate:string = moment(x.date,"YYYY-MM-DD").format("MMM-YYYY");
        this.calories.push(+x.calories);
        this.calDate.push(myDate);
      });

       console.log(this.calories);
      console.log(this.calDate);

      this.CalorieChart = new Chart('CalorieCanvas', {
        type: 'line',
        data: {
          labels: this.calDate,

          datasets: [
            {
              data : this.calories, 
              label: "Consumed",
              backgroundColor: 'rgba(54,190,166,.1)',
              borderColor: '#2962ff',
            },
            {
              data: this.caloriesBurnt,
              label: "Burnt",
              backgroundColor: 'rgb(41,98,255,.1)',
              borderColor: '	#FF6347',
              pointBackgroundColor: '	#FF6347',
              pointBorderColor: '#fff',
              pointHoverBackgroundColor: '#fff',
              pointHoverBorderColor: '#FF6347'
            }
          ],

        
        },
        options: {
          legend: {
            display: true
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
