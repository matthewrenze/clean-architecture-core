﻿namespace CleanArchitecture.Specification.Sales.GetSalesList
{
    public class GetSalesListModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Customer { get; set; } = string.Empty;

        public string Employee { get; set; } = string.Empty;

        public string Product { get; set; } = string.Empty;

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
