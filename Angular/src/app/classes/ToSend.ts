import { Basket } from "./basket";


export class ToSend{
    constructor(public EmailUser:string,public Baskets:Array<Basket>,public TotalPriceToSend:number){}
}