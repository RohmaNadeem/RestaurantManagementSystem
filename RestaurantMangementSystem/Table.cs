using System;

namespace RestaurantMangementSystem
{
    [Serializable]
    public class Table
    {
        // Core properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; } 
        public string Status { get; set; }   
        public decimal MinimumOrder { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }

        // Reservation details
        public string ReservedFor { get; set; }
        public DateTime? ReservationTime { get; set; }
        public string ReservationNotes { get; set; }
        public int? CurrentOrderId { get; set; }

        // Visual layout properties
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public int Width { get; set; } = 90;
        public int Height { get; set; } = 70;

        // Calculated status helpers
        public bool IsAvailable => Status == "Available";
        public bool IsOccupied => Status == "Occupied";
        public bool IsReserved => Status == "Reserved";

        // Status color for UI (used in floor plan)
        public string StatusColor
        {
            get
            {
                switch (Status)
                {
                    case "Available": return "#4CAF50";
                    case "Occupied": return "#F44336";
                    case "Reserved": return "#FF9800";
                    case "Cleaning": return "#2196F3";
                    case "Maintenance": return "#9E9E9E";
                    default: return "#9E9E9E";
                }
            }
        }

        // ✅ This override makes the ListBox display friendly names
        public override string ToString()
        {
            return $"{Name} ({Capacity} seats) - {Status}";
        }
    }
}