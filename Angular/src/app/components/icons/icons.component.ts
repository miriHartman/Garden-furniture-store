import { Component, EventEmitter, Input,  Output } from '@angular/core';

@Component({
  selector: 'app-icons',
  standalone: true,
  imports: [],
  templateUrl: './icons.component.html',
  styleUrl: './icons.component.css'
})
export class IconsComponent {
  //מאפייני התגיץ איקון
@Input() icon:string|undefined;
@Input() name:string="";
@Input() id:string|undefined
@Output() newClickIcon=new EventEmitter()
 
myevent(){
  this.newClickIcon.emit()
 }
}
