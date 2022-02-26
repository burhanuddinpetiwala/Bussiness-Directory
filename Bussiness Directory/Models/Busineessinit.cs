using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Bussiness_Directory.Models
{
    public class Busineessinit : DropCreateDatabaseAlways<BusinessDBContext>
    {
        protected override void Seed(BusinessDBContext context)
        {


            context.Bussinesses.Add(new Bussiness
            {
                bussinessId = "1",
                Bussname = "Google",
                Busslogo = "./images/itachi.jpg",
                location = "Ontario",
                discription = "Best company in the world",
                BussPhoneNumber = "+1647949428"
            }); 
            base.Seed(context);
        }
    }
}