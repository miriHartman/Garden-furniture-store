import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from '../classes/Product';
import { Basket } from '../classes/basket';
import { ProductService } from './product.service';
//שרת מערך הקניות

@Injectable({
  providedIn: 'root'
})
export class BasketService {
  public MyBasket:Array<Basket>=new Array<Basket>()
  totalost:number=0
  constructor(public server:HttpClient,public productService:ProductService){}
   numProduct:number=0
   //כמות המוצרים הכוללת- הנוכחית
   changeNumProd(num:number){
    this.numProduct+=num
   }
   //ניתן להוסיף מוצר גם בסל
  addProd(pb:Basket){
    var  p1:Product  = this.productService.AllP.filter(gg=>gg.Id==pb.pId)[0]
    var myBs:Basket=this.MyBasket.filter(a=>a.pId==pb.pId)[0]
    if(myBs)
      {
       if(p1.Amount-myBs.pQuty-pb.pQuty>=0){
      this.MyBasket.filter(r=>r.pId==pb.pId)[0].pQuty+=pb.pQuty
      this.MyBasket.filter(r=>r.pId==pb.pId)[0].pTotalPrice+=pb.pTotalPrice
      this.totalost+=pb.pTotalPrice
      
         }
        }
      
        else
        {
          if(p1.Amount-pb.pQuty>=0){
          this.MyBasket.push(pb)
        console.log(this.MyBasket);
        this.totalost+=pb.pTotalPrice
        }
       
        
    
  }
}
}
