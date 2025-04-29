import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Company } from '../classes/Company';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {
AllCom:Array<Company>=new Array<Company>
  constructor(public server:HttpClient) {   }
  //שליפת כל החברות 
  getAllCompany():Observable<Array<Company>>{
    return this.server.get<Array<Company>>('https://localhost:7252/api/company')
  }
}
