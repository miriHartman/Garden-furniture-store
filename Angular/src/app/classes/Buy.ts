export class Buy{
    constructor(
    public  Id :number,
        public  UserId :number,
        public DateOfBuy:Date ,
        public  AmountPay:number, 
        public  UserName :string,
        public IsPay:boolean,
        public  Remark?:string){} }