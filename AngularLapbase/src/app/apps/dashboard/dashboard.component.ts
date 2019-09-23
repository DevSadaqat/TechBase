import { Component, AfterViewInit } from '@angular/core';
import {PatientService} from '../../services/patient.service';
import {Patient} from '../../models/Patient';
import { getNumberOfCurrencyDigits } from '@angular/common';
import { WeightService } from '../../services/weight.service';
import {Weight} from '../../models/Weight';
import {WeightList} from '../../models/weightList';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements AfterViewInit {
  height: number;
  weightBMI: number;
  bmi: number;
  message: string;
  patID: string;
  orgCode: string;
  latestWeight: Observable<Weight>;
  weightStr:string;
  patient: Patient = {
  PatientID: "",
  Title: "",
  Surname: "",
  Firstname: "",
  Birthdate: "",
  Age: "",
  Gender: "",
  Height: "",
  PhoneNumber: "",
  HomePhone: "",
  ContactEmail: "",
  RefDrName1: "",
  BMI: "",
  Street: "",
  Suburb: "",
  City: "",
  State: "",
  PinCode: "",
  Country: "",
  TargetWeight: "",
  CurrentWeight: "",
  Insurance: "",
  InsuranceEmployer: "",
  InusuranceNumber: "",
  MedicareNumber: "",
  }
  weight: Weight = {

    WeightValue: "",
    PatientID: "",
    OrganizationCode: "",
  }
  weightListAll: WeightList = {
    weight: "",
    dateAdded: "",
  }
  
  constructor(private pat_Serv: PatientService,private weightService: WeightService) { }


//Calorie Chart  
  public lineChartData: Array<any> = [
    { data: [65, 39, 80, 15, 76, 35, 40, 98, 657, 258, 286, 657], label: 'Calories Consumed' },
    { data: [200, 59, 27, 90, 67, 57, 15, 12, 65, 25, 84, 65], label: 'Calories Burnt' }
    
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
  public WeightChartData: Array<any> = [
    { data: [55, 56, 77 , 88, 95, 100], label: 'Weight' }

  ];

  public WeightChartLabels: Array<any> = [
    '1/1/1995',
    '1/1/1998',
    '1/1/2001',
    '1/1/2004',
    '1/1/2007',
    '1/1/2010',
    '1/1/2013',
    '1/1/2016',
    '1/1/2019',
    '1/1/2022',
  ];

  public WeightChartOptions: any = {
    responsive: true
  };

  public WeightChartColors: Array<any> = [
   
  ];

  public WeightChartLegend = true;
  public WeightChartType = 'line';

  
  
  ngAfterViewInit() { 
    this.patID  = localStorage.getItem("patientID");
    this.orgCode = localStorage.getItem("organizationCode");
  
    this.pat_Serv.getPatientById(this.patID,this.orgCode).subscribe(data =>
    {        
    
      this.patient = data[0];
      console.log(this.patient);
    
      localStorage.setItem("Height", data.Height);
   
    });
    var intHeight = localStorage.getItem("Height");
    //console.log(intHeight);
    this.height = +intHeight;
    this.height = this.height/100;
    //console.log(this.height);

    //method to call list of all weights
    this.weightService.getAllWeights(this.patID,this.orgCode).subscribe(data =>
      {
          this.weightListAll = data;
          localStorage.setItem("weight", data.weight);
          console.log(this.weightListAll);
      });
 // array of weight numbers
     var weights  = localStorage.getItem("weight");
    
  }
  calcBMI(event){
    // window.alert(97);
     event.preventDefault()
     const target = event.target
     this.weightBMI = target.querySelector('#Weight').value;
     //console.log(this.weight);
    this.bmi = this.weightBMI/(this.height*this.height);
    this.bmi = +this.bmi.toFixed(2);
    //console.log(this.bmi);
    if(this.bmi<18.5)
    {
      this.message = "Underweight"
    }
    else if(this.bmi>=18.5 && this.bmi <25)
    {
      this.message = "Healthy"
    }
    else if(this.bmi>=25 && this.bmi <30)
    {
      this.message = "Overweight"
    }
    else
    {
      this.message = "Obese"
    }
   }
   weightUser(event){
    // window.alert(97);
    
     event.preventDefault()
     const target = event.target
    
     this.weight.WeightValue =target.querySelector('#WeightValue').value
     
   
   
    // window.alert(97);
     this.CreateWeight(this.weight);
   }
   getLatestWeight()
  {
    this.latestWeight = this.weightService.getLatestWeight(this.patID,this.orgCode);
   
  }
   CreateWeight(weight: Weight) {  
     //if (this.foodIdUpdate == null) {  
       weight.PatientID = this.patID;
       weight.OrganizationCode = this.orgCode;
       console.log(weight);
      // window.alert(86);
       this.weightService.createWeight(weight).subscribe(  
         () => {  
           
         }  
       );  
   }
  
  }
