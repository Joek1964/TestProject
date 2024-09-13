Random random = new();

int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

/*if <= 10
   ""
else if <= 5
   ""
else if == 1
   ""
else
   ""  */

   Console.WriteLine(daysUntilExpiration);

if (daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
    } else if(daysUntilExpiration <= 5){
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days until expiration.");
        Console.WriteLine("Renew now and save 10%");
        discountPercentage = 10;
        } else if(daysUntilExpiration == 1){
            Console.WriteLine("Your subscription expires within a day!");
            Console.WriteLine("Renew now and save 20%");
            discountPercentage = 20;
        }else{
            Console.WriteLine("Your subscription has expired");
        }
    
