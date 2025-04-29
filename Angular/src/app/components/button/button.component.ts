import { Component, EventEmitter, Input,  Output } from '@angular/core';

@Component({
  selector: 'app-button',
  standalone: true,
  imports: [],
  templateUrl: './button.component.html',
  styleUrl: './button.component.css'
})
export class ButtonComponent {
  //האפשרויות שמכיל הכפתור
@Input() icon:string|undefined;
@Input() name:string="";
@Input() id:string|undefined
@Output() newClick=new EventEmitter()
 event1(){
  //אירוע על הכפתור יבצע את הפונקציה שתשלח לו בnewClick
  this.newClick.emit()
 }
}
