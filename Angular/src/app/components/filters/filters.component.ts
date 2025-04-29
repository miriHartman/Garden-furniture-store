import { Component, OnInit } from '@angular/core';
import { Category } from '../../classes/Category';
import { CompanyService } from '../../services/company.service';
import { CategoryService } from '../../services/category.service';
import { ProductService } from '../../services/product.service';
import { Product } from '../../classes/Product';
import { FormsModule } from '@angular/forms';
import { IconsComponent } from '../icons/icons.component';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-filters',
  standalone: true,
  imports: [FormsModule,IconsComponent],
  templateUrl: './filters.component.html',
  styleUrl: './filters.component.css'
})
export class FiltersComponent  implements OnInit{
//כאן ישמרו הנתונים אותם רוצה הלקוח בסינונו
  p1:Product=new Product(0,"",0,"",0,"",0,0,"",new Date(),"")

  
  constructor(public copSer:CompanyService,public cateSer:CategoryService,public prodSer:ProductService,public route:Router) {
    
  }
  ngOnInit(): void {
    this.getAllCat()
    this.getAllComp()
  }
myprice:number=0

myPrice(price:number){
//המחיר אותו בוחר הלקוח
  this.myprice=price
}
filter(){
  this.prodSer.getAllProductsFilter(this.p1.CategoryId,this.p1.CompanyId,this.p1.Price)
  .subscribe(
    //שליפת המוצרים בקריאת השרת- זו קריאה לשרת על פי הנתונים
      t=>{
        this.prodSer.AllP=t
        this.route.navigate([`allProduct/${this.p1.CategoryId}`])
        console.log("here oooo!!");

      },
      err=>{
console.log(err);

      }
    )
}
//הצגת הקטגוריות האפשריות
getAllCat(){
this.cateSer.getallCat().subscribe(
  f=>{
   this.cateSer.AllCat=f 
   this.route.navigate([`allProduct/${0}`])
  
  },
  err=>{
    console.log("error");
    
  })
}
//הצגת החברות האפשריות
getAllComp(){
  this.copSer.getAllCompany().subscribe(
    s=>{
   this.copSer.AllCom=s
   this.route.navigate([`allProduct/${0}`])

    },
    err=>{
  console.log(err);
    }
  )
}
//מיונים עפ מחיר מהגבוה לנמול או להיפך
sortSmall(){
  this.prodSer.AllP=this.prodSer.AllP.sort((a,b)=>a.Price-b.Price)
}
sortBig(){
  this.prodSer.AllP=this.prodSer.AllP.sort((a,b)=>b.Price-a.Price)
}

}
