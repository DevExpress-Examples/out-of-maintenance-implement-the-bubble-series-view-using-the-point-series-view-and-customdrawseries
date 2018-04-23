using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void chartControl1_CustomDrawSeriesPoint(object sender, DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs e) {
            DataRowView drv = e.SeriesPoint.Tag as DataRowView;
            ((DevExpress.XtraCharts.PointDrawOptions)e.SeriesDrawOptions ).Marker.Size = Convert.ToInt32(drv["Rad"]);
        }

        private void Form1_Load(object sender, EventArgs e) {
            dataSet1.DataTable1.AddDataTable1Row("A", 10, 10);
            dataSet1.DataTable1.AddDataTable1Row("B", 20, 20);
            dataSet1.DataTable1.AddDataTable1Row("C", 30, 15);
            dataSet1.DataTable1.AddDataTable1Row("D", 40, 8);
        }
    }
}