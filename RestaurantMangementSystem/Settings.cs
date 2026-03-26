using System;

namespace RestaurantMangementSystem
{
    [Serializable]
    public class Settings
    {
        // General
        public bool AutoBackup { get; set; } = false;

        // Restaurant Info
        public string RestaurantName { get; set; } = "Green Leaf Restaurant";
        public string Address { get; set; } = "123 Green Street, City";
        public string Phone { get; set; } = "+1 (555) 123-4567";
        public string Email { get; set; } = "info@greenleafrestaurant.com";
        public decimal TaxRate { get; set; } = 10.0m;

        // POS
        public string ReceiptHeader { get; set; } = "Thank you for dining with us!";
        public string ReceiptFooter { get; set; } = "Visit us again soon!";
        public bool AutoPrintReceipt { get; set; } = true;
        public bool ShowPreviewBeforePrint { get; set; } = false;
        public bool AlwaysAskForTable { get; set; } = false;

        // Printer
        public string SelectedPrinter { get; set; } = "Default Printer";
        public string PaperSize { get; set; } = "80mm";

        // Security
        public string AdminPassword { get; set; } = "admin123";
        public bool AutoLock { get; set; } = false;
        public bool AuditLog { get; set; } = true;
    }
}