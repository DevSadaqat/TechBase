import { Component, AfterViewInit } from '@angular/core';
import { PerfectScrollbarConfigInterface } from 'ngx-perfect-scrollbar';
import * as c3 from 'c3';
import * as Chartist from 'chartist';
import { ChartType, ChartEvent } from 'ng-chartist';
import * as shape from 'd3-shape';
import * as d3 from 'd3';
//import { single } from './data';
import { colorSets } from '@swimlane/ngx-charts/release/utils/color-sets';


declare var require: any;

const data: any = require('./data.json');


export interface Chart {
    type: ChartType;
    data: Chartist.IChartistData;
    options?: any;
    responsiveOptions?: any;
    events?: ChartEvent;
}


@Component({
    templateUrl: './dashboard1.component.html',
    styleUrls: ['./dashboard1.component.css']
})

export class Dashboard1Component implements AfterViewInit {

    
    lineChart2: Chart = {
        type: 'Line',
        data: data['Line'],
        options: {
            low: 0,
            height: 400,
            showArea: true,
            fullWidth: true
        }
    };
    
    constructor() {
        
    }

    ngAfterViewInit() {
        
    }
}
