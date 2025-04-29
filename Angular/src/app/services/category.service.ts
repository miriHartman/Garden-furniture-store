import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../classes/Category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  AllCat:Array<Category>=new Array<Category>
  constructor(public server:HttpClient) { }
  // שליפת כל הקטגוריות 
  getallCat():Observable<Array<Category>>{
    return this.server.get<Array<Category>>('https://localhost:7252/api/category')
  }
}
