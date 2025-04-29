import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { User } from '../../classes/User';
import { RegisterService } from '../../services/register.service';
import { RouterOutlet } from '@angular/router';
import {Router} from '@angular/router';
import swal from 'sweetalert'
@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule,RouterOutlet],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
  constructor(public res:RegisterService,public route:Router){}
  //כאן יישמרו נתוני הלקוח
user1:User=new User(0,"","",new Date(),"")
save(){
  //שמירת הלקוח- קריאת שרת
  this.res.addUser(this.user1).subscribe(
data=>{
if (data==1){
  swal("you are in","success")
this.route.navigate([`./pay`])
}

},
err=>{
  console.log(err);  
}

  )
}
}
