import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../classes/Product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  AllP:Array<Product>=new Array<Product>
  AllPF:Array<Product>=new Array<Product>
  constructor(public server:HttpClient) {}
  getAllProducts():Observable<Array<Product>>{
    return this.server.get<Array<Product>>('https://localhost:7252/api/product')
  }
  //שליפת המוצרים הנבחרים על פי הסינון
  getAllProductsFilter(categoryId:number,companyId:number,price:number):Observable<Array<Product>>{
   const params=new HttpParams()
   .set('categoryId', categoryId)
   .set('companyId', companyId)
   .set('price', price);
    
    return  this.server.get<Array<Product>>('https://localhost:7252/api/product/filter',{params})
  }
}
