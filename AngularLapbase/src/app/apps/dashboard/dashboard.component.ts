import { Component, AfterViewInit } from '@angular/core';
import {PatientService} from '../../services/patient.service';
import { WeightService } from '../../services/weight.service';
import { FoodService } from '../../services/food.service';
import { ExcerciseService } from '../../services/excercise.service';
import {Patient} from '../../models/Patient';
import { getNumberOfCurrencyDigits } from '@angular/common';

import {Weight} from '../../models/Weight';
import {WeightList} from '../../models/weightList';
import {Bmi} from '../../models/Bmi';
import {BmiList} from '../../models/bmiList';
import { ToastrService } from 'ngx-toastr';
import * as moment from 'moment';
import {Chart} from 'chart.js'
import { Observable } from 'rxjs';
import { Calories } from 'src/app/models/Calories';
import {WeightLost } from '../../models/EWL';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements AfterViewInit {
  height: number;
  weightBMI: string;
  bmi: number;
  message: string;
  patID: string;
  orgCode: string;
 // latestWeight: Observable<Weight>;
  weightStr:string;
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
  weight: Weight = {

    WeightValue: "",
    PatientID: "",
    OrganizationCode: "",
    BMI: ""
  }
  // weightListAll: WeightList = {
  //   weight: "",
  //   dateAdded: "",
 // }
  bmiData: Bmi = {
    BMI: "",
    message: ""
  }
  //for weight graph
  weightGraph: WeightList[];
  weightNum: number[]= [];
  DateG:string[]=[];
  Weightchart:any = [];

  //for BMI Graph 
  bmiNum: number[] = [];
  bmidate: string[]=[];
  Bmichart: any = [];

  //for calories graph
  calories: number[] = [];
  calDate: string[]=[];
  CalorieChart: any = [];
  caloriesBurnt: number[] = [];

  //for EWL graph
  ewl: number[] = [];
  ewlDate:  string[]=[];

  constructor(private pat_Serv: PatientService, 
             private weightService: WeightService, 
             private foodService: FoodService,
             private exerciseService: ExcerciseService, 
             private toastr: ToastrService) { }

//display this message when user adds weight
weightMessage() {
  this.toastr.success('Your weight has been added!', 'Success!');
}
meridian = true;
seconds = true;
toggleSeconds() {
  this.seconds = !this.seconds;
}

/*
//BMI Chart
public bmiChartData: Array<any> = [
  { data: [65, 39, 80, 15, 76, 35, 40, 98, 657, 258, 286, 657], label: 'BMI' }

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
/*
  public lineChartData: Array<any> = [
    // { data: [65, 39, 80, 15, 76, 35, 40, 98, 657, 258, 286, 657], label: 'Calories Consumed' },
    // { data: [200, 59, 27, 90, 67, 57, 15, 12, 65, 25, 84, 65], label: 'Calories Burnt' }

  ];

  public lineChartLabels: Array<any> = [
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
      pointHoverBorderColor: '#FF6347'
    }
  ];

  public lineChartLegend = true;
  public lineChartType = 'line';


  // public WeightChartData: Array<any> = [];
  // public WeightChartLabels: Array<any> = [];

  //Weight Chart
  // public WeightChartData: Array<any> = [
  //   { data: [95, 99, 90, 89, 85, 83, 82, 78, 85, 80, 75, 77], label: 'Weight' }

  // ];

  // public WeightChartLabels: Array<any> = [
  //   '1/1/1995',
  //   '1/1/1998',
  //   '1/1/2001',
  //   '1/1/2004',
  //   '1/1/2007',
  //   '1/1/2010',
  //   '1/1/2013',
  //   '1/1/2016',
  //   '1/1/2019',
  //   '1/1/2022',
  // ];


  // public WeightChartLegend = true;
  // public WeightChartType = 'line';

  */
  ngAfterViewInit() {
    this.patID  = localStorage.getItem("patientID");
    this.orgCode = localStorage.getItem("organizationCode");
    this.getLatestWeight()
    this.getWeightGraph()
    this.getBMIGraph()
    //displays patients demographics and baseline data
    this.pat_Serv.getPatientById(this.patID,this.orgCode).subscribe(data =>
    {

      this.patient = data[0];
      console.log(this.patient);
      // localStorage.setItem("Height", data.Height);
    });

    //method to display EWL of patient on dasboard
    this.pat_Serv.getEWLData(this.patID,this.orgCode).subscribe((res: WeightLost[]) =>
    {
      console.log(res);
     res.forEach(x => {
       let myDate:string = moment(x.Date,"YYYY-MM-DD").format("MMM-YYYY");
         this.ewl.push(+x.EWL);
         this.ewlDate.push(myDate);
       });
     });
    console.log(this.ewl);
   //method display list of all burnt consumed 
   this.exerciseService.CaloriesBurnt(this.patID,this.orgCode).subscribe((res: Calories[]) =>
   {
     console.log(res);
    res.forEach(x => {
      let myDate:string = moment(x.date,"YYYY-MM-DD").format("DD-MM-YYYY");
        this.caloriesBurnt.push(+x.calories);
      //  this.calDate.push(myDate);
        //console.log("1");
       // console.log(this.weightNum);
       // console.log("1");
    // console.log(x.dateAdded);
      });
    });

   //method display list of all calories consumed 
   this.foodService.CaloriesConsumed(this.patID,this.orgCode).subscribe((res: Calories[]) =>
   {
     console.log(res);
    res.forEach(x => {
      let myDate:string = moment(x.date,"YYYY-MM-DD").format("DD-MM-YYYY");
        this.calories.push(+x.calories);
        this.calDate.push(myDate);
        //console.log("1");
       // console.log(this.weightNum);
       // console.log("1");
    // console.log(x.dateAdded);
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
      console.log("13");
      console.log(this.Bmichart);
      console.log("13");
    //method to get BMI of patient
    this.weightService.getBmi(this.patID, this.orgCode, this.weightBMI).subscribe(data =>
      {
        this.bmiData = data;
        console.log(this.bmiData);
      });

 // array of weight numbers
   //  var weights  = localStorage.getItem("weight");

  }

  //method to call list of all weights to display on graph 
  getWeightGraph(){
    this.weightService.getAllWeights(this.patID,this.orgCode).subscribe((res: WeightList[]) =>
      {
      res.forEach(x => {
        let myDate:string = moment(x.dateAdded,"YYYY-MM-DD").format("MMM-YYYY");

          this.weightNum.push(+x.weight);
          this.DateG.push(myDate);
          //console.log("1");
         // console.log(this.weightNum);
         // console.log("1");
      // console.log(x.dateAdded);
        });
       // console.log(res);
        this.Weightchart = new Chart('canvas', {
          type: 'line',
          data: {
             labels: this.DateG,
            datasets: [
              {
                data : this.weightNum,
                label: "Weight(kg)",
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
                pointHoverBorderColor: '#2962ff'*/
                // borderColor: '#3cb371',
                // backgroundColor: "#0000FF",
              }/*,
              {
                data: this.ewl,
                label: "EWL",
                borderColor: '#FF6347',
                backgroundColor: 'rgb(41,98,255,.1)'
              }*/
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
    }

     //method to call BMIs to display on Graph
     getBMIGraph(){
     this.weightService.getBmiForGraph(this.patID,this.orgCode).subscribe((res: BmiList[]) =>
     {
      console.log(res);
     res.forEach(x => {
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
               label: "BMI",
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
  //method to get latest weight
  getLatestWeight()
  {
    this.weightService.getLatestWeight(this.patID,this.orgCode).subscribe(data =>
      {
        this.weight = data;
        console.log(this.weight);
      });
  }
  //method to calculate BMI
  calcBMI(event){
    // window.alert(97);
     event.preventDefault()
     const target = event.target
     this.weightBMI = target.querySelector('#Weight').value;

     console.log(this.weightBMI);

      //method to get BMI of patient
    this.weightService.getBmi(this.patID, this.orgCode, this.weightBMI).subscribe(data =>
      {
        this.bmiData = data;
        console.log(this.bmiData);
      });
   }
   weightUser(event){
    // window.alert(97);

     event.preventDefault()
     const target = event.target
     this.weight.WeightValue =target.querySelector('#WeightValue').value
     this.weightService.getBmi(this.patID, this.orgCode, this.weight.WeightValue).subscribe(data =>
      {
        this.weight.BMI= (+data.BMI).toFixed(1).toString();
       // console.log(this.bmiData);
      });
     console.log(this.weight.WeightValue);
    // window.alert(97);
     this.CreateWeight(this.weight);

   }

   CreateWeight(weight: Weight) {
       weight.PatientID = this.patID;
       weight.OrganizationCode = this.orgCode;
       console.log(weight);
       this.weightService.createWeight(weight).subscribe(
         () => {

         }
       );
       this.getWeightGraph();
       this.getBMIGraph();
   }

  }
