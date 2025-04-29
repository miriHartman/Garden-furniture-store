import { NgStyle } from '@angular/common';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ProductService } from '../../services/product.service';
import { IconsComponent } from '../icons/icons.component';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [NgStyle,IconsComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  constructor(public route:Router,public ps:ProductService){}
 to(num:number){ 
  //שלית המוצרים וניתוב לדף הצגת המוצרים על פי הקטגוריה הנבחרת
this.ps.getAllProductsFilter(num,0,0).subscribe(
  u=>{
    this.route.navigate([`./allProduct/${num}`])
    this.ps.AllP=u
})

}
}
