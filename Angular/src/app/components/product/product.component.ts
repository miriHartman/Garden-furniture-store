import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../services/product.service';
import { Product } from '../../classes/Product';
import { ActivatedRoute, Router, RouterOutlet } from '@angular/router';
import { NgClass, NgStyle } from '@angular/common';
import { FiltersComponent } from '../filters/filters.component';
import { AfterBuyDirective } from '../../directive/after-buy.directive';
import { BasketService } from '../../services/basket.service';
import { log } from 'console';
import { Basket } from '../../classes/basket';
import { ButtonComponent } from '../button/button.component';
import { IconsComponent } from '../icons/icons.component';

@Component({
  selector: 'app-product',
  standalone: true,
  imports: [RouterOutlet,NgClass,NgStyle,FiltersComponent,AfterBuyDirective,ButtonComponent,IconsComponent],
  templateUrl: './product.component.html',
  styleUrl: './product.component.css',
  
})
export class ProductComponent implements OnInit  {
  constructor(public pc:ProductService,public route:Router,public bs:BasketService,public activeRoute:ActivatedRoute){
  }
  // basketp:basket=new basket("","",0,0)
  id?:number


  ngOnInit(): void {
this.activeRoute.params.subscribe(
 (v)=>{
this.id=v['id']
  }
)
    this.get()
  }
  //מלכתכילה עד ביצוע סינון מוצגים כלל המוצרים
get(){
  if(!this.id){
  this.pc.getAllProducts().subscribe(
    f=>{
      this.pc.AllP=f      
    },
    err=>{
console.log(err);
    
    }
  )
}
//אם הגענו מניתוב של קטגוריה מסויימת או סינון יוצגו רק הפריטין הנצרכים
if(this.id!=null){
  this.pc.getAllProductsFilter(this.id,0,0).subscribe(
    f=>{
      this.pc.AllP=f      
    },
    err=>{
console.log(err);
    
    }
  )


}



}
//ניתוב לפרטים נוספים לכל מוצר
moreDetails(p:Product){
this.route.navigate([`./details/${p.Id}`])
}
//הוספה לסל
addCart(p:Product){
  var  p1:Product  = this.pc.AllP.filter(gg=>gg.Id==p.Id)[0]
  var  b1:Basket= this.bs.MyBasket.filter(uu=>uu.pId==p.Id)[0]
  var sum=1
  //אם כבר קיים מוצר כזה בסל עולה כמות ההזמנה
  if(b1){
    sum=b1.pQuty+1}
  if(p1.Amount-sum>=0){
   //אם לא קיים עדין מוצר כזה בסל - אזי נוסף המוצר 
  var basketp1:Basket=new Basket(p.Id,p.Name,1,p.Price,p.Price,p.Picture,p.Description);
  this.bs.addProd(basketp1)
  this.bs.changeNumProd(1)
  }
}
}
