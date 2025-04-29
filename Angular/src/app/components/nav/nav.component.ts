import { Component } from '@angular/core';
import {RouterLink,Router, RouterOutlet} from '@angular/router';
import { BasketService } from '../../services/basket.service';


@Component({
  selector: 'app-nav',
  standalone: true,
  imports: [RouterLink,RouterOutlet],
  templateUrl: './nav.component.html',
  styleUrl: './nav.component.css'
})
export class NavComponent {
  constructor(public route:Router,public bs:BasketService){}
  
  //הניתובים האפשריים
  allProductf(){
    this.route.navigate([`./allProduct`])
  }
  homef(){
    this.route.navigate([`./home`])
  }
  basketF(){
    this.route.navigate([`./basket`])
  }
  
 

}
