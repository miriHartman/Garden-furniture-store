import { Component } from '@angular/core';
import { ProductService } from '../../services/product.service';
import { ActivatedRoute } from '@angular/router';
import { Product } from '../../classes/Product';
import { Location } from '@angular/common';
import { BasketService } from '../../services/basket.service';
import { Basket } from '../../classes/basket';

@Component({
  selector: 'app-details',
  standalone: true,
  imports: [],
  templateUrl: './details.component.html',
  styleUrl: './details.component.css'
})
export class DetailsComponent {
Id:number=0
 public currentProd:Product=new Product(0,"",0,"",0,"",0,0,"",new Date)
 public count:number=1
constructor(public ps:ProductService,public ar:ActivatedRoute,public loc:Location,public bs:BasketService){
ar.params.subscribe(
  d=>{
    //מוצר נוכחי עליו עומדים
    this.Id=d['pId']
    let prod=ps.AllP.find(a =>a.Id == this.Id)
    if(prod)
      this.currentProd=prod

  }
)

}
//חזרה לעמוד הקודם בו היו
back(){
  this.loc.back()
}
//הוספה לסל כמובן רק במקרה שקיים במלאי
addCart(p:Product){
  var p1:Product=this.ps.AllP.filter(yy=>yy.Id==p.Id)[0]
   var b1:Basket=this.bs.MyBasket.filter(qq=>qq.pId==p.Id)[0]
  if(this.count>0 ){
    if(b1 && p1.Amount-this.count-b1.pQuty>=0 || !b1 && p1.Amount-this.count>=0){
  var basketp1:Basket=new Basket(p.Id,p.Name,this.count,p.Price,this.count*p.Price,p.Picture,p.Description);
  this.bs.addProd(basketp1)
this.bs.changeNumProd(this.count)}}
}
// הכמות אותה רוצים להזמין לאחר מכן בadd cart
minus(num:number){
if(this.count>0)
  this.count--

}
plus(num:number){
  if(this.currentProd.Amount>this.count)
 this.count++

}
}
