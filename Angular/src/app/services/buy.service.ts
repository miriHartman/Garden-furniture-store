import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ToSend } from '../classes/ToSend';
import { Buy } from '../classes/Buy';
import { Basket } from '../classes/basket';

@Injectable({
  providedIn: 'root'
})
export class BuyService {

  constructor(public server:HttpClient) { }
  myTosend:ToSend=new ToSend("", Array<Basket>(),0)
  myBuy:Buy=new Buy(0,0,new Date,0,"",false,"")
  //יצירת אובייקט קניה שישלח לשרת
  getMyBuy():Observable<Buy>{
    //שליפת הקניה שלי על מנת להציגה 
    console.log(this.myTosend);
   return this.server.post<Buy>('https://localhost:7252/api/buy',this.myTosend)
  }
  //אישור התשלום בקניה
  confirmBuy():Observable<number>{
    return this.server.get<number>(`https://localhost:7252/api/buy/Id?Id=${this.myBuy.Id}`)
  }
}
