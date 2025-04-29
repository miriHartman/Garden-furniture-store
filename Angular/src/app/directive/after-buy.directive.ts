import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appAfterBuy]',
  standalone: true
})
export class AfterBuyDirective {

  constructor(private el: ElementRef) {}
  @HostListener('click') onClick() {
    this.butonBuy('yellow');
  }
  //לאחר שהזמנו מוצר כזה כפתור ההוספה לסל מעוצב שונה
  private butonBuy(color: string) {
    this.el.nativeElement.style.backgroundColor = color;
  }

}
