export class Product{
constructor(public Id:number,
     public Name:string,
     public CategoryId:number,
     public nameCategory: string,
    public CompanyId:number,
    public nameCompany:string,
    public Price:number,
    public Amount:number,
    public Picture:string,
     public LastUpdate:Date,
     public Description?:string
){}
}

        