import { Component, AfterViewChecked } from '@angular/core';
import { ScrollHelper } from '../helpers/scrollhelper/scrollhelper';

@Component({
    selector: 'home',
	templateUrl: './home.component.html',
	styleUrls: ['./home.component.css', './vendor/bootstrap/css/bootstrap.min.css','./css/creative.min.css']
})
export class HomeComponent {
	private scrollHelper: ScrollHelper = new ScrollHelper();
	ngAfterViewChecked() {
		this.scrollHelper.doScroll();
	}

	scrollToContact() {
		this.scrollHelper.scrollToFirst('scrollcontact');
		this.scrollHelper.doScroll();
	}

	scrollToMain() {
		this.scrollHelper.scrollToFirst('masthead');
		this.scrollHelper.doScroll();
	}

	scrollToAbout() {
		this.scrollHelper.scrollToFirst('bg-primary');
		this.scrollHelper.doScroll();
	}

}
