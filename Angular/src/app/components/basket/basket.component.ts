import { Component } from '@angular/core';
import { BasketService } from '../../services/basket.service';
import {RouterLink,Router, RouterOutlet} from '@angular/router';
import { Basket } from '../../classes/basket';
import { ButtonComponent } from '../button/button.component';
import { ProductService } from '../../services/product.service';
import { Product } from '../../classes/Product';

@Component({
  selector: 'app-basket',
  standalone: true,
  imports: [ButtonComponent],
  templateUrl: './basket.component.html',
  styleUrl: './basket.component.css'
})

export class BasketComponent {
 constructor( public bs:BasketService,public route:Router,public ps:ProductService){}
 
 plus(p:Basket){
  //העלאת כמות למוצר קיים
   var p1:Product=this.ps.AllP.filter(yy=>yy.Id==p.pId)[0]
   var b1:Basket=this.bs.MyBasket.filter(qq=>qq.pId==p.pId)[0]
   //כמובן רק במקרה שיש כמות שכזו במלאי
   if(b1 && p1.Amount-b1.pQuty-1>=0 || !b1 && p1.Amount-1>0){
   p.pQuty=p.pQuty+1
   p.pTotalPrice+=p.pPrice
   this.bs.changeNumProd(1)
   this.bs.totalost+=p.pPrice
   }
}
minus(p:Basket){
  //הפחתת כמות ההזמנה
  if(p.pQuty>0){
  p.pQuty=p.pQuty-1;
  p.pTotalPrice-=p.pPrice
  this.bs.changeNumProd(-1)
  this.bs.totalost-=p.pPrice

}
}
remove(pb:Basket){
  //מחיקת המוצר מהסל
  var a=this.bs.MyBasket.indexOf(pb)
  this.bs.changeNumProd(-pb.pQuty)
  this.bs.MyBasket.splice(a,1)
  this.bs.totalost-=pb.pTotalPrice
}
topay(){
  //לתשלום על כלל המוצרים
  if(this.bs.MyBasket.length>0 && this.bs.totalost!=0)
    //מעביר לכניסת המשתמש - או הרשמתו
  this.route.navigate([`/login`])
  else
  swal("","סל המוצרים שלך ריק מלא בו מוצרים לקניה")
}
}
