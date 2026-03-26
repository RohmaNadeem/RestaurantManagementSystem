using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace RestaurantMangementSystem
{
    public static class TableStorage
    {
        private static readonly string StorageFile = "tables.xml";
        private static List<Table> tables = new List<Table>();
        private static int nextId = 1;

        static TableStorage()
        {
            LoadTables();
        }

        public static void LoadTables()
        {
            try
            {
                if (File.Exists(StorageFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Table>));
                    using (FileStream file = File.OpenRead(StorageFile))
                    {
                        tables = (List<Table>)serializer.Deserialize(file);
                        if (tables.Count > 0)
                            nextId = tables.Max(t => t.Id) + 1;
                    }
                }
                else
                {
                    CreateSampleTables();
                    SaveTables();
                }
            }
            catch
            {
                tables = new List<Table>();
                CreateSampleTables();
                SaveTables();
            }
        }

        public static void SaveTables()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Table>));
                using (TextWriter writer = new StreamWriter(StorageFile))
                {
                    serializer.Serialize(writer, tables);
                }
            }
            catch { }
        }

        private static void CreateSampleTables()
        {
            tables = new List<Table>
            {
                new Table { Id = 1, Name = "Table 1", Capacity = 2, Location = "Window", Status = "Available", MinimumOrder = 0, IsActive = true, CreatedDate = DateTime.Now, XPosition = 50, YPosition = 50 },
                new Table { Id = 2, Name = "Table 2", Capacity = 4, Location = "Window", Status = "Available", MinimumOrder = 0, IsActive = true, CreatedDate = DateTime.Now, XPosition = 200, YPosition = 50 },
                new Table { Id = 3, Name = "Table 3", Capacity = 6, Location = "Center", Status = "Occupied", MinimumOrder = 50, IsActive = true, CreatedDate = DateTime.Now, XPosition = 400, YPosition = 50 },
                new Table { Id = 4, Name = "Table 4", Capacity = 2, Location = "Bar", Status = "Cleaning", MinimumOrder = 0, IsActive = true, CreatedDate = DateTime.Now, XPosition = 600, YPosition = 50 },
                new Table { Id = 5, Name = "Table 5", Capacity = 8, Location = "Private", Status = "Reserved", MinimumOrder = 100, IsActive = true, CreatedDate = DateTime.Now, XPosition = 50, YPosition = 200 },
                new Table { Id = 6, Name = "Table 6", Capacity = 4, Location = "Center", Status = "Available", MinimumOrder = 0, IsActive = true, CreatedDate = DateTime.Now, XPosition = 250, YPosition = 200 },
                new Table { Id = 7, Name = "Table 7", Capacity = 2, Location = "Window", Status = "Available", MinimumOrder = 0, IsActive = true, CreatedDate = DateTime.Now, XPosition = 450, YPosition = 200 },
                new Table { Id = 8, Name = "Table 8", Capacity = 6, Location = "Center", Status = "Occupied", MinimumOrder = 60, IsActive = true, CreatedDate = DateTime.Now, XPosition = 650, YPosition = 200 }
            };
            nextId = 9;
        }

        public static List<Table> GetAllTables() => new List<Table>(tables);

        public static Table GetTableById(int id) => tables.Find(t => t.Id == id);

        public static List<Table> GetTablesByStatus(string status) =>
            tables.FindAll(t => t.Status == status && t.IsActive);

        public static void AddTable(Table table)
        {
            table.Id = nextId++;
            table.CreatedDate = DateTime.Now;
            table.LastUpdated = DateTime.Now;
            tables.Add(table);
            SaveTables();
        }

        public static bool UpdateTable(Table updated)
        {
            var existing = tables.Find(t => t.Id == updated.Id);
            if (existing == null) return false;
            existing.Name = updated.Name;
            existing.Capacity = updated.Capacity;
            existing.Location = updated.Location;
            existing.Status = updated.Status;
            existing.MinimumOrder = updated.MinimumOrder;
            existing.IsActive = updated.IsActive;
            existing.XPosition = updated.XPosition;
            existing.YPosition = updated.YPosition;
            existing.LastUpdated = DateTime.Now;
            SaveTables();
            return true;
        }

        public static bool DeleteTable(int id)
        {
            var table = tables.Find(t => t.Id == id);
            if (table == null) return false;
            table.IsActive = false;
            table.LastUpdated = DateTime.Now;
            SaveTables();
            return true;
        }

        public static List<Table> SearchTables(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm)) return GetAllTables();
            searchTerm = searchTerm.ToLower();
            return tables.FindAll(t => t.Name.ToLower().Contains(searchTerm) ||
                                      t.Location.ToLower().Contains(searchTerm) ||
                                      t.Status.ToLower().Contains(searchTerm));
        }

        // ✅ This method is used by POS to update table status
        public static bool UpdateTableStatus(int tableId, string status, string reservedFor = null,
            DateTime? reservationTime = null, string notes = null)
        {
            var table = tables.Find(t => t.Id == tableId);
            if (table != null)
            {
                table.Status = status;
                table.LastUpdated = DateTime.Now;

                if (status == "Reserved")
                {
                    table.ReservedFor = reservedFor;
                    table.ReservationTime = reservationTime;
                    table.ReservationNotes = notes;
                }
                else if (status == "Available")
                {
                    table.ReservedFor = null;
                    table.ReservationTime = null;
                    table.ReservationNotes = null;
                    table.CurrentOrderId = null;
                }

                SaveTables();
                return true;
            }
            return false;
        }

        public static bool UpdateTablePosition(int tableId, int x, int y)
        {
            var table = tables.Find(t => t.Id == tableId);
            if (table != null)
            {
                table.XPosition = x;
                table.YPosition = y;
                table.LastUpdated = DateTime.Now;
                SaveTables();
                return true;
            }
            return false;
        }

        public static List<Table> GetTablesForLayout() =>
            tables.Where(t => t.IsActive).ToList();

        public static int GetTotalTables() => tables.Count(t => t.IsActive);
        public static int GetAvailableTables() => tables.Count(t => t.Status == "Available" && t.IsActive);
        public static int GetOccupiedTables() => tables.Count(t => t.Status == "Occupied" && t.IsActive);
        public static int GetReservedTables() => tables.Count(t => t.Status == "Reserved" && t.IsActive);
        public static int GetTotalSeats() => tables.Where(t => t.IsActive).Sum(t => t.Capacity);
        public static int GetAvailableSeats() => tables.Where(t => t.Status == "Available" && t.IsActive).Sum(t => t.Capacity);
    }
}