import { Component, OnInit } from '@angular/core';
import { BuyService } from '../../services/buy.service';
import { Router } from '@angular/router';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-payfinal',
  standalone: true,
  imports: [DatePipe],
  templateUrl: './payfinal.component.html',
  styleUrl: './payfinal.component.css'
})
export class PayfinalComponent implements OnInit{
  constructor(public by:BuyService,public route:Router){}
ngOnInit(): void {
  //הצגת הקבלה הסופית ללקוח לאחר התשלום
  this.toInit()
}
toInit(){
  this.by.myBuy.DateOfBuy
this.by.confirmBuy().subscribe(
  ok=>{
console.log("ok"+ok);
  },
  err=>{
    console.log(err);  
  })}

}
