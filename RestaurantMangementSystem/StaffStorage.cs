using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace RestaurantMangementSystem
{
    public static class StaffStorage
    {
        private static readonly string StorageFile = "staff.xml";
        private static List<StaffMember> staffList = new List<StaffMember>();
        private static int nextId = 1;

        static StaffStorage()
        {
            LoadStaff();
        }

        public static void LoadStaff()
        {
            try
            {
                if (File.Exists(StorageFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<StaffMember>));
                    using (FileStream file = File.OpenRead(StorageFile))
                    {
                        staffList = (List<StaffMember>)serializer.Deserialize(file);
                        if (staffList.Count > 0)
                            nextId = staffList.Max(s => s.Id) + 1;
                    }
                }
                else
                {
                    CreateSampleStaff();
                    SaveStaff();
                }
            }
            catch
            {
                staffList = new List<StaffMember>();
                CreateSampleStaff();
                SaveStaff();
            }
        }

        public static void SaveStaff()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<StaffMember>));
                using (TextWriter writer = new StreamWriter(StorageFile))
                {
                    serializer.Serialize(writer, staffList);
                }
            }
            catch { }
        }

        private static void CreateSampleStaff()
        {
            // Your existing sample data, using StaffMember
            staffList = new List<StaffMember>
            {
                new StaffMember
                {
                    Id = 1,
                    EmployeeId = "EMP001",
                    FirstName = "John",
                    LastName = "Smith",
                    Role = "Manager",
                    Email = "john.smith@restaurant.com",
                    Phone = "555-0101",
                    Address = "123 Main St",
                    DateOfBirth = new DateTime(1985, 5, 15),
                    HireDate = new DateTime(2020, 1, 10),
                    Salary = 5000.00m,
                    Shift = "Morning",
                    IsActive = true,
                    Status = "Working",
                    EmergencyContact = "Mary Smith",
                    EmergencyPhone = "555-0102",
                    Notes = "",
                    Username = "john",
                    Password = "1234",
                    PresentDaysThisMonth = 20,
                    AbsentDaysThisMonth = 0,
                    LateDaysThisMonth = 1,
                    OvertimeHoursThisMonth = 8.5m
                },
                // Add other sample staff...
            };
            nextId = staffList.Max(s => s.Id) + 1;
        }

        // All your existing CRUD methods, using StaffMember
        public static List<StaffMember> GetAllStaff() => new List<StaffMember>(staffList);
        public static StaffMember GetStaffById(int id) => staffList.Find(s => s.Id == id);
        public static List<string> GetAllRoles() => staffList.Select(s => s.Role).Distinct().ToList();
        public static List<string> GetAllShifts() => staffList.Select(s => s.Shift).Distinct().ToList();

        public static void AddStaff(StaffMember staff)
        {
            staff.Id = nextId++;
            staff.CreatedDate = DateTime.Now;
            staff.LastUpdated = DateTime.Now;
            if (string.IsNullOrEmpty(staff.EmployeeId))
                staff.EmployeeId = $"EMP{staff.Id.ToString().PadLeft(3, '0')}";
            staffList.Add(staff);
            SaveStaff();
        }

        public static bool UpdateStaff(StaffMember updated)
        {
            var existing = staffList.Find(s => s.Id == updated.Id);
            if (existing == null) return false;
            // Copy properties...
            existing.FirstName = updated.FirstName;
            existing.LastName = updated.LastName;
            existing.Role = updated.Role;
            existing.Email = updated.Email;
            existing.Phone = updated.Phone;
            existing.Address = updated.Address;
            existing.DateOfBirth = updated.DateOfBirth;
            existing.HireDate = updated.HireDate;
            existing.Salary = updated.Salary;
            existing.Shift = updated.Shift;
            existing.IsActive = updated.IsActive;
            existing.Status = updated.Status;
            existing.EmergencyContact = updated.EmergencyContact;
            existing.EmergencyPhone = updated.EmergencyPhone;
            existing.Notes = updated.Notes;
            existing.Username = updated.Username;
            existing.Password = updated.Password;
            existing.LastUpdated = DateTime.Now;
            SaveStaff();
            return true;
        }

        public static bool DeleteStaff(int id)
        {
            var staff = staffList.Find(s => s.Id == id);
            if (staff == null) return false;
            staff.IsActive = false;
            staff.Status = "Resigned";
            staff.LastUpdated = DateTime.Now;
            SaveStaff();
            return true;
        }

        public static List<StaffMember> SearchStaff(string term)
        {
            if (string.IsNullOrWhiteSpace(term)) return GetAllStaff();
            term = term.ToLower();
            return staffList.Where(s =>
                (s.FirstName != null && s.FirstName.ToLower().Contains(term)) ||
                (s.LastName != null && s.LastName.ToLower().Contains(term)) ||
                (s.EmployeeId != null && s.EmployeeId.ToLower().Contains(term)) ||
                (s.Role != null && s.Role.ToLower().Contains(term)) ||
                (s.Email != null && s.Email.ToLower().Contains(term))).ToList();
        }

        public static List<StaffMember> GetActiveStaff() => staffList.Where(s => s.IsActive).ToList();
        public static int GetTotalStaff() => staffList.Count;
        public static int GetActiveStaffCount() => staffList.Count(s => s.IsActive);
        public static int GetStaffOnLeaveCount() => staffList.Count(s => s.Status == "On Leave" && s.IsActive);
        public static decimal GetTotalMonthlySalary() => staffList.Where(s => s.IsActive).Sum(s => s.Salary);
        public static decimal GetTotalSalaryThisMonth() => staffList.Where(s => s.IsActive).Sum(s => s.SalaryThisMonth);
        public static string GenerateEmployeeId() => $"EMP{nextId.ToString().PadLeft(3, '0')}";
        public static bool UsernameExists(string username) => staffList.Any(s => s.Username == username);
        public static bool EmailExists(string email) => staffList.Any(s => s.Email == email);
    }
}