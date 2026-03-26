using System;

namespace RestaurantMangementSystem
{
    [Serializable]
    public class StaffMember
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public string Shift { get; set; }
        public bool IsActive { get; set; }
        public string Status { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }

        // Attendance
        public int PresentDaysThisMonth { get; set; }
        public int AbsentDaysThisMonth { get; set; }
        public int LateDaysThisMonth { get; set; }
        public decimal OvertimeHoursThisMonth { get; set; }

        public decimal SalaryThisMonth => (PresentDaysThisMonth * (Salary / 30)) + (OvertimeHoursThisMonth * HourlyRate * 1.5m);

        public string Username { get; set; }
        public string Password { get; set; }

        // Calculated properties
        public int Age => DateTime.Now.Year - DateOfBirth.Year;
        public int YearsOfService => DateTime.Now.Year - HireDate.Year;
        public decimal HourlyRate => Salary / 160;

        public string RoleColor
        {
            get
            {
                switch (Role)
                {
                    case "Manager": return "#9C27B0";
                    case "Chef": return "#FF5722";
                    case "Waiter": return "#2196F3";
                    case "Cashier": return "#4CAF50";
                    case "Cleaner": return "#795548";
                    case "Admin": return "#F44336";
                    default: return "#9E9E9E";
                }
            }
        }

        // For ListBox display
        public override string ToString()
        {
            return $"{FullName} - {Role} ({Status})";
        }
    }
}