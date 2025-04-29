export class User{
    constructor(
        public Id: number  ,
        public Name:string  ,
        public  Email :string,
        public Bearthday:Date ,
        public Phone?:string 
    ){}
}