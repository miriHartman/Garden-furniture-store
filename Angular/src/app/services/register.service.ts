import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../classes/User';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {
  //שמירת המייל של הלקוח הנוכחי
  EmailUser:string=""
  
  constructor(public server:HttpClient) { }
  //הרשמת לקוח
  addUser(user:User):Observable<number>{
    this.EmailUser=user.Email
    return this.server.post<number>('https://localhost:7252/api/user',user)
  }
   login(Email:string):Observable<boolean>{
    this.EmailUser=Email
    //נסיון לכניסה  יתבצע רק אם הלקוח אכן קיים
    return this.server.get<boolean>(`https://localhost:7252/userEmail?userEmail=${Email}`)
  }
}
