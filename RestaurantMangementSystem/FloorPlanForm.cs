using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class FloorPlanForm : Form
    {
        private List<Table> tables;
        private Table draggedTable = null;
        private bool isDragging = false;
        private Point dragStart;
        private Point originalPosition;

        public FloorPlanForm()
        {
            InitializeComponent();
            LoadTables();
            SetupPanel();
        }

        private void LoadTables()
        {
            tables = TableStorage.GetTablesForLayout();
        }

        private void SetupPanel()
        {
            panelFloor.AutoScroll = true;
            panelFloor.BackColor = Color.FromArgb(250, 250, 252); // very light gray
            panelFloor.MouseDown += PanelFloor_MouseDown;
            panelFloor.MouseMove += PanelFloor_MouseMove;
            panelFloor.MouseUp += PanelFloor_MouseUp;
            panelFloor.Paint += panelFloor_Paint;
        }

        private void panelFloor_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            DrawZones(g);
            DrawTables(g);
        }

        private void DrawZones(Graphics g)
        {
            using (Font zoneFont = new Font("Segoe UI", 8, FontStyle.Regular))
            {
                // Window area
                Rectangle windowArea = new Rectangle(20, 20, 200, panelFloor.Height - 60);
                using (Brush b = new SolidBrush(Color.FromArgb(30, 173, 216, 230))) // light blue tint
                    g.FillRectangle(b, windowArea);
                g.DrawString("WINDOW", zoneFont, Brushes.CornflowerBlue, windowArea.X + 10, windowArea.Y + 10);

                // Private area
                Rectangle privateArea = new Rectangle(panelFloor.Width - 220, 20, 200, 200);
                using (Brush b = new SolidBrush(Color.FromArgb(30, 255, 215, 0)))
                    g.FillRectangle(b, privateArea);
                g.DrawString("PRIVATE", zoneFont, Brushes.Goldenrod, privateArea.X + 10, privateArea.Y + 10);

                // Bar area
                Rectangle barArea = new Rectangle(panelFloor.Width - 220, 250, 200, 150);
                using (Brush b = new SolidBrush(Color.FromArgb(30, 220, 20, 60)))
                    g.FillRectangle(b, barArea);
                g.DrawString("BAR", zoneFont, Brushes.Crimson, barArea.X + 10, barArea.Y + 10);

                // Center area
                Rectangle centerArea = new Rectangle(240, 20, panelFloor.Width - 480, panelFloor.Height - 60);
                using (Brush b = new SolidBrush(Color.FromArgb(20, 144, 238, 144)))
                    g.FillRectangle(b, centerArea);
                g.DrawString("CENTER", zoneFont, Brushes.ForestGreen, centerArea.X + 10, centerArea.Y + 10);
            }
        }

        private void DrawTables(Graphics g)
        {
            foreach (var table in tables)
            {
                Rectangle rect = new Rectangle(table.XPosition, table.YPosition, table.Width, table.Height);

                // Soft shadow
                Rectangle shadowRect = new Rectangle(rect.X + 3, rect.Y + 3, rect.Width, rect.Height);
                using (Brush shadowBrush = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
                {
                    GraphicsPath shadowPath = CreateRoundedRectangle(shadowRect, 8);
                    g.FillPath(shadowBrush, shadowPath);
                }

                // Table background – solid pastel based on status
                Color tableColor = ColorTranslator.FromHtml(table.StatusColor);
                using (Brush tableBrush = new SolidBrush(Color.FromArgb(230, tableColor))) // semi-transparent
                {
                    GraphicsPath path = CreateRoundedRectangle(rect, 8);
                    g.FillPath(tableBrush, path);
                    using (Pen pen = new Pen(Color.FromArgb(80, 0, 0, 0), 1))
                        g.DrawPath(pen, path);
                }

                // Table name (short)
                string displayName = table.Name.Length > 10 ? table.Name.Substring(0, 8) + "…" : table.Name;
                using (Font nameFont = new Font("Segoe UI", 8, FontStyle.Bold))
                {
                    SizeF nameSize = g.MeasureString(displayName, nameFont);
                    float nameX = rect.X + (rect.Width - nameSize.Width) / 2;
                    float nameY = rect.Y + 10;
                    g.DrawString(displayName, nameFont, Brushes.Black, nameX, nameY);
                }

                // Capacity (smaller)
                string capText = $"{table.Capacity} seats";
                using (Font capFont = new Font("Segoe UI", 7, FontStyle.Regular))
                {
                    SizeF capSize = g.MeasureString(capText, capFont);
                    float capX = rect.X + (rect.Width - capSize.Width) / 2;
                    float capY = rect.Y + 30;
                    g.DrawString(capText, capFont, Brushes.DimGray, capX, capY);
                }

                // Optional: tiny status dot
                Rectangle dotRect = new Rectangle(rect.Right - 15, rect.Y + 5, 8, 8);
                using (Brush dotBrush = new SolidBrush(tableColor))
                    g.FillEllipse(dotBrush, dotRect);
            }
        }

        private GraphicsPath CreateRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void PanelFloor_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var table in tables)
            {
                Rectangle rect = new Rectangle(table.XPosition, table.YPosition, table.Width, table.Height);
                if (rect.Contains(e.Location))
                {
                    isDragging = true;
                    draggedTable = table;
                    dragStart = e.Location;
                    originalPosition = new Point(table.XPosition, table.YPosition);
                    panelFloor.Cursor = Cursors.SizeAll;
                    break;
                }
            }
        }

        private void PanelFloor_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && draggedTable != null)
            {
                int dx = e.X - dragStart.X;
                int dy = e.Y - dragStart.Y;
                draggedTable.XPosition = originalPosition.X + dx;
                draggedTable.YPosition = originalPosition.Y + dy;
                panelFloor.Invalidate();
            }
        }

        private void PanelFloor_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging && draggedTable != null)
            {
                TableStorage.UpdateTablePosition(draggedTable.Id, draggedTable.XPosition, draggedTable.YPosition);
                isDragging = false;
                draggedTable = null;
                panelFloor.Cursor = Cursors.Default;
            }
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadTables();
            panelFloor.Invalidate();
        }
    }
}