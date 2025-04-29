import { Routes } from '@angular/router';
import { DetailsComponent } from './components/details/details.component';
import { ProductComponent } from './components/product/product.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { BasketComponent } from './components/basket/basket.component';
import { PayComponent } from './components/pay/pay.component';
import { PayfinalComponent } from './components/payfinal/payfinal.component';


export const routes: Routes = [
    {
    path:"home",component:HomeComponent,title:"home"
    
},{
    path:"login",component:LoginComponent,title:"login"
},
{
    
path:"allProduct",component:ProductComponent,title:"products",

},{
    path:"details/:pId",component:DetailsComponent,title:"more details"
},{
    path:"register" ,component:RegisterComponent,title:"register"
},{
    path:"basket",component:BasketComponent,title:"basket"
},{
    path:"pay",component:PayComponent,title:"pay"
},
{path:"finalpay",component:PayfinalComponent ,title:"finalpay"},
{path:"allProduct/:id",component:ProductComponent ,title:"products"}

];
