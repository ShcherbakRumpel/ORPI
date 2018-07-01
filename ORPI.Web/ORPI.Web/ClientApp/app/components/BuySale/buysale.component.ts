import { Component } from '@angular/core';

@Component({
    selector: 'counter',
	templateUrl: './buysale.component.html',
	styleUrls: ['./buysale.component.css']
})
export class BuySaleComponent {
    public currentCount = 0;

    public incrementCounter() {
        this.currentCount++;
    }
}
