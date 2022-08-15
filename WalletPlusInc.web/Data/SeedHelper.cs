using WalletPlusInc.web.Data.Entities;

namespace WalletPlusInc.web.Data
{
    public class SeedHelper
    {
        public static async Task Seed(ApplicationDbContext context)
        {
            //Check if the database is populated
            if (!context.Customers.Any())
            {
                //Create Sample Data
                context.Customers.Add(new Customer
                {
                    FirstName = "David",
                    LastName = "Chukwuemeka",
                    MiddleName = "Johnson",
                    Gender = GenderEnum.Male,
                    MaritalStatus = MaritalStatusEnum.Single,
                    BirthDate = DateTime.Now.AddYears(-2),
                    Country = "Nigeria",
                    State = "Lagos",
                    City = "Gbagada",
                   
                    
                    
                    
                });

                context.Customers.Add(new Customer
                {
                    FirstName = "Onuorah",
                    LastName = "Agwagu",
                    MiddleName = "Prosper",
                    Gender = GenderEnum.Male,
                    MaritalStatus = MaritalStatusEnum.Married,
                    BirthDate = DateTime.Now.AddYears(-2),
                    Country = "Nigeria",
                    State = "Enugu",
                    City = "Abakpa",




                });
                await context.SaveChangesAsync();
            }

            if (!context.Countries.Any())
            {
                context.Countries.AddRange(new List<Country>
                {
                 new Country {Names="Afganisthan",IsoCode="AFG",CallCode="004"},
                 new Country {Names="Aland Islands",IsoCode="ALA",CallCode="248"},
                 new Country {Names="Albania",IsoCode="ALB",CallCode="008"}
                });
                await context.SaveChangesAsync();
            }



        }
        
    }
}

