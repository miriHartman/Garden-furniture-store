import { Component, OnInit } from '@angular/core';
import { BuyService } from '../../services/buy.service';
import { ToSend } from '../../classes/ToSend';
import { RegisterService } from '../../services/register.service';
import { BasketService } from '../../services/basket.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-pay',
  standalone: true,
  imports: [],
  templateUrl: './pay.component.html',
  styleUrl: './pay.component.css'
})
export class PayComponent implements OnInit {
constructor(public by:BuyService,public us:RegisterService,public bs:BasketService,public route:Router){}
ngOnInit(): void {
    this.myKabala()
}
 myKabala(){
  
  this.by.myTosend.EmailUser=this.us.EmailUser
  this.by.myTosend.Baskets=this.bs.MyBasket,
  this.by.myTosend.TotalPriceToSend= this.bs.totalost
  // שליפה מהשרת שקניה של הלקוח
   this.by.getMyBuy().subscribe(
     e=>{
      console.log(e);
     this.by.myBuy=e
     
    },
    u=>{
      console.log(u);
      
    }

  )
}
confirm(){
//אישור הקניה
    this.route.navigate(['./finalpay'])
  
}


}
