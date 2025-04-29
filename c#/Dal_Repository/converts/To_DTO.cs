using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal_Repository.converts
{
    public class To_DTO
    {//company
       
        public static DTO_Common.classes.Company toCompanyDto(Dal_Repository.classes.Company comp1)
        {

        DTO_Common.classes.Company com_dto=new DTO_Common.classes.Company();
            com_dto.Name = comp1.Name;
            com_dto.Id = comp1.Id; 
            return com_dto;

       }

        public static List< DTO_Common.classes.Company> toListCompanyDto(List< Dal_Repository.classes.Company> complist)
        {
            List<DTO_Common.classes.Company> com_list_dto=new List<DTO_Common.classes.Company>();
            foreach(var l in complist) {
            com_list_dto.Add(toCompanyDto(l));
            }
            return com_list_dto;
            

        }
        //buy
        public static DTO_Common.classes.Buy toBuyDto(Dal_Repository.classes.Buy buy1,string nameUser)
        {
            DTO_Common.classes.Buy buy_dto=new DTO_Common.classes.Buy();
            buy_dto.DateOfBuy = buy1.DateOfBuy;
            buy_dto.UserId = buy1.UserId;
            buy_dto.Id= buy1.Id;
            buy_dto.UserName = nameUser;
            buy_dto.Remark = buy1.Remark;
            buy_dto.AmountPay = buy1.AmountPay;
            return buy_dto;
        }

        //buy detailes
        public static DTO_Common.classes.Buy_Detailes toBuy_datailsDto(Dal_Repository.classes.Buy_Detailes buy_detaiels1)
        {
            DTO_Common.classes.Buy_Detailes buy_d_dto=new DTO_Common.classes.Buy_Detailes();
            buy_d_dto.BuyId=buy_detaiels1 .BuyId;
            buy_d_dto.ProductId=buy_detaiels1 .ProductId;
            buy_d_dto.Id=buy_detaiels1 .Id;
            buy_d_dto.Amount=buy_detaiels1 .Amount;
            return   buy_d_dto;
        }
        //product
        public static DTO_Common.classes.Product toProductDto(Dal_Repository.classes.Product Product_dal)
        {
            DTO_Common.classes.Product pr_dto=new DTO_Common.classes.Product();
            pr_dto.Id = Product_dal .Id;
            pr_dto.Name=Product_dal .Name;
            pr_dto.Amount = Product_dal .Amount;
            pr_dto.Description=Product_dal .Description;
            pr_dto.CategoryId=Product_dal .CategoryId;
            pr_dto.CompanyId=Product_dal .CompanyId;
            pr_dto.LastUpdate=Product_dal .LastUpdate;
            pr_dto.Price=Product_dal .Price;
            pr_dto.nameCategory=Product_dal.Category.Name;
            pr_dto.nameCompany = Product_dal.Company.Name;
            pr_dto.Picture=Product_dal .Picture;

            return pr_dto;
            
        }

        public static List<DTO_Common.classes.Product> toListProductDto(List<Dal_Repository.classes.Product> pr_dal)
        {
            List<DTO_Common.classes.Product> com_list_dto = new List<DTO_Common.classes.Product>();
            foreach (var l in pr_dal)
            {
                com_list_dto.Add(toProductDto(l));
            }
            return com_list_dto;
        }
//category
     public static DTO_Common.classes.Category toCategoryDto(Dal_Repository.classes.Category category)
        {
            DTO_Common.classes.Category cat_dto=new DTO_Common.classes.Category();
            cat_dto.Name=category.Name;
            cat_dto.Id=category.Id;
            return cat_dto;
        }
     public static List<DTO_Common.classes.Category> toListCategoryDto(List< Dal_Repository.classes.Category> list_dal_cat)
        {
            List<DTO_Common.classes.Category> cat_dto_list=new List<DTO_Common.classes.Category>();
            foreach(var l in list_dal_cat)  
                cat_dto_list.Add(toCategoryDto(l));
            return cat_dto_list;
        }
//user
   public static DTO_Common.classes.User toUserDto(Dal_Repository.classes.User user)
        {
            DTO_Common.classes.User user_dto=new DTO_Common.classes.User();
            
            user_dto.Id=user.Id;
            user_dto.Name = user.Name;
            user_dto.Phone=user.Phone;
            user_dto.Email=user.Email;
            user_dto.Bearthday=user.Bearthday;
            return user_dto;
        }




    }
}
