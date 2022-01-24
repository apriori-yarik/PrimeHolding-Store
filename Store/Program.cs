// See https://aka.ms/new-console-template for more information

using Store;

Cashier cashier = new Cashier(new Cart(Seeding.GetProductsWithQuantity), Seeding.DateOfPurchase);
cashier.PrintReceipt();