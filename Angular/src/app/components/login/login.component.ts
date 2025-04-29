import { Component } from '@angular/core';
import { RegisterService } from '../../services/register.service';
import { FormsModule } from '@angular/forms';
import {Router} from '@angular/router';
import swal from 'sweetalert';
import { ButtonComponent } from '../button/button.component';
@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule,ButtonComponent],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  constructor(public res:RegisterService,public route:Router){}
Email:string=""
Name:string=""
toPay(){
  //קריאת שרת לבדיקה האם הלקוח אכן רשום
this.res.login(this.Email).subscribe(
  ok=>{
    if(ok==true){
    this.route.navigate([`./pay`])}
  else{
    //אם לא הפניה להרשמה
    swal("","עליך להרשם קודם",'error')

  this.route.navigate([`./register`])}


  },
  no=>{
   console.log(no);
  }
)
}
register(){
  this.route.navigate([`./register`])
}

}
