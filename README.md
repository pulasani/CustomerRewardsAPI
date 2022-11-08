
# Caluculate Customer reward points

Create web api endpoint to calculate the reward points earned for each customer per month and total. 

# Customer Rewards end point
Controller Name : Customer

End point Name : GetCustomersRewardPoints

Request:
 http://localhost:54510/api/Customer/GetCustomersRewardPoints

Response : 
[{"custId":1,"fullName":"Jhon J","numberOfTransactions":3,"month":"Nov","totalAmount":785,"rewardPoints":1420},{"custId":2,"fullName":"Smith S","numberOfTransactions":3,"month":"Oct","totalAmount":680,"rewardPoints":1210}]


# Health Check 
 
End point Name : Health

Request:
 http://localhost:54510/health

Response : 

Healthy


# Mock Data

 

        //Customer Transactions Details
        public static List<Transaction> Transactions()
        {
            return new List<Transaction>
            {
                new Transaction{ CustId = 1, TransactionId = 1,  Amount = 120, TransactionDate = DateTime.Now},
                new Transaction{ CustId = 1, TransactionId = 2,  Amount = 650, TransactionDate = DateTime.Now},
                new Transaction{ CustId = 1, TransactionId = 3,  Amount = 15, TransactionDate = DateTime.Now},
                new Transaction{ CustId = 2, TransactionId = 1,  Amount = 90, TransactionDate = DateTime.Now.AddMonths(-1)},
                new Transaction{ CustId = 2, TransactionId = 2,  Amount = 550, TransactionDate = DateTime.Now.AddMonths(-1)},
                new Transaction{ CustId = 2, TransactionId = 3,  Amount = 40, TransactionDate = DateTime.Now.AddMonths(-1)},
            };
        }

        //Customer Details
        public static List<Customer> Customers()
        {
            return new List<Customer>
            {
                new Customer{ CustId = 1, FirstName = "Jhon", LastName = "J", Gender="M", PhoneNumber ="000000000"},
                new Customer{ CustId = 2, FirstName = "Smith", LastName = "S", Gender="M", PhoneNumber ="000000000"},
            };
        }
