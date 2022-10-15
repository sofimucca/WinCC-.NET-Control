using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace TrendChartLibrary
{

    public partial class TrendChart : UserControl
    {

        Form form1 = new Form();

        Form form2 = new Form();

        DataTable dt = new DataTable();

        CheckedListBox checkedListBox = new CheckedListBox();

        VerticalLineAnnotation ruler = new VerticalLineAnnotation();

        DataGridView dataGridView1 = new DataGridView();

        bool showCheckedListBox = true;
        int Index = 0;

        public int TrendWidth
        {
            get { return chart1.Width; }
            set
            {

                chart1.Width = value;
            }
        }
        public int TrendHeight
        {
            get { return chart1.Height; }
            set { chart1.Height = value; }
        }

        public Color ChartBackColor
        {
            get { return chart1.ChartAreas[0].BackColor; }
            set { chart1.ChartAreas[0].BackColor = value; }
        }

        public Color ChartInterlacedColor
        {
            get { return chart1.ChartAreas[0].AxisX.InterlacedColor; }
            set
            {
                chart1.ChartAreas[0].AxisX.InterlacedColor = value;
                chart1.ChartAreas[0].AxisY.InterlacedColor = value;
            }
        }

        public Color ChartLineColor
        {
            get { return chart1.ChartAreas[0].AxisX.LineColor; }
            set
            {
                chart1.ChartAreas[0].AxisX.LineColor = value;
                chart1.ChartAreas[0].AxisY.LineColor = value;
            }
        }

        public Color ChartMajorGridLIneColor
        {
            get { return chart1.ChartAreas[0].AxisX.MajorGrid.LineColor; }
            set
            {
                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = value;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = value;
            }
        }

        public Color ChartMinorGridLIneColor
        {
            get { return chart1.ChartAreas[0].AxisX.MinorGrid.LineColor; }
            set
            {
                chart1.ChartAreas[0].AxisX.MinorGrid.LineColor = value;
                chart1.ChartAreas[0].AxisY.MinorGrid.LineColor = value;
            }
        }

        public bool TrendShowLabel
        {

            get
            {
                if (chart1.Series.Count == 0)
                {
                    return false;
                }
                else
                {
                    return chart1.Series[Index].IsValueShownAsLabel;
                }



            }

            set
            {
                if (chart1.Series.Count > 0)
                {
                    chart1.Series[Index].IsValueShownAsLabel = value;
                }

            }
        }

        public bool TrendShowLegend
        {

            get
            {

                return chart1.Legends[0].Enabled;

            }

            set
            {
                chart1.Legends[0].Enabled = value;
            }
        }

        public bool TrendShowCheckedListBox
        {

            get
            {

                return showCheckedListBox;

            }

            set
            {
                showCheckedListBox = value;
            }
        }

        public string TrendName
        {
            get
            {

                if (chart1.Series.Count == 0)
                {
                    return "";
                }
                else
                {


                    return chart1.Series[Index].Name;


                }



            }
            set
            {
                if (chart1.Series.Count > 0)
                {
                    chart1.Series[Index].Name = value;
                }


            }
        }

        public Color TrendColor
        {
            get
            {

                if (chart1.Series.Count == 0)
                {
                    return Color.White;
                }
                else
                {
                    return chart1.Series[Index].Color;
                }



            }
            set
            {
                if (Index < chart1.Series.Count)
                {
                    chart1.Series[Index].Color = value;
                    chart1.Series[Index].LabelForeColor = value;

                }



            }
        }

        public string TrendAxisXLabel
        {
            get { return chart1.ChartAreas[0].AxisX.Title; }
            set { chart1.ChartAreas[0].AxisX.Title = value; }
        }

        public string TrendAxisY1Label
        {
            get { return chart1.ChartAreas[0].AxisY.Title; }
            set { chart1.ChartAreas[0].AxisY.Title = value; }
        }

        public string TrendAxisY2Label
        {
            get { return chart1.ChartAreas[0].AxisY2.Title; }
            set { chart1.ChartAreas[0].AxisY2.Title = value; }
        }

        public string TrendAdd
        {
            get
            {
                return "";
            }

            set
            {
                if (value != "")
                {
                    chart1.Series.Add(new Series { Name = value });


                };



            }

        }

        public string TrendRemove
        {

            get
            {
                return "";
            }

            set
            {
                foreach (Series trend in chart1.Series)
                {
                    if (trend.Name == value)
                    {
                        chart1.Series.Remove(trend);
                        break;
                    }
                }
                int max = 0;
                int min = 0;

                if (chart1.Series.Count == 0)
                {
                    max = 0;
                }
                else
                {
                    max = chart1.Series.Count - 1;
                }

                Index = Clamp(Index, min, max);

                chart1.Update();
                ;

            }

        }

        public double TrendAxisXMax
        {
            get { return chart1.ChartAreas[0].AxisX.Maximum; }
            set
            {

                chart1.ChartAreas[0].AxisX.Maximum = value;


            }


        }
        public double TrendAxisYMax
        {
            get { return chart1.ChartAreas[0].AxisY.Maximum; }
            set
            {
                chart1.ChartAreas[0].AxisY.Maximum = value;


            }


        }

        public int TrendIndex

        {
            get
            {
                return Index;
            }
            set
            {
                int max = 0;
                int min = 0;

                if (chart1.Series.Count == 0)
                {
                    max = 0;
                }
                else
                {
                    max = chart1.Series.Count - 1;
                }

                Index = Clamp(value, min, max);

            }
        }

        public int TrendCount

        {
            get
            {
                return chart1.Series.Count;
            }

        }




        public static int Clamp(int value, int min, int max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        public TrendChart()
        {
            InitializeComponent();
        }


        public void ChangeColor(int trendIndex, string color)
        {
            if (trendIndex < chart1.Series.Count)
            {
                chart1.Series[trendIndex].Color = Color.FromName(color);
            }
            chart1.Update();
        }

        public void AddTrend(int trendIndex, string trendName, string color, bool showMeasures, string toolTip, int markerSize, int axisYType)
        {

            Series trend = new Series();
            
            while (chart1.Series.Count <= trendIndex) { chart1.Series.Add(trend); };

            chart1.Series[trendIndex].Name = trendName;
            chart1.Series[trendIndex].MarkerSize = markerSize;
            chart1.Series[trendIndex].Name = trendName;
            chart1.Series[trendIndex].ToolTip = toolTip;
            chart1.Series[trendIndex].Color = Color.FromName(color);
            chart1.Series[trendIndex].IsValueShownAsLabel = showMeasures;
            chart1.Series[trendIndex].LabelForeColor = Color.FromName(color);
            chart1.Series[trendIndex].YAxisType = (AxisType)axisYType;
            chart1.Series[trendIndex].ChartArea = "ChartArea1";
            chart1.Series[trendIndex].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[trendIndex].Legend = "Legend1";
            chart1.Series[trendIndex].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;

        }


        public void RemoveData(int trendIndex)
        {
            if (chart1.Series.Count > trendIndex)
            {

                chart1.Series[trendIndex].Points.Clear();

            }

        }

        public void InsertData(int trendIndex, int pointIndex, double x, double y)
        {

            if (trendIndex < chart1.Series.Count)
            {

                while (chart1.Series[trendIndex].Points.Count <= pointIndex) { chart1.Series[trendIndex].Points.Add(); };

                chart1.Series[trendIndex].Points[pointIndex].SetValueXY(x, y);

            }

        }

        public void UpdateChart()
        {
            chart1.Update();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (form1.Created)
            {
                form1.Close();
                return;
            }

            form1 = new Form
            {
                Text = "Trends",
                ShowIcon = false,
                TopMost = true,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowOnly,
                StartPosition = FormStartPosition.Manual,
                Location = chart1.Location
            };


            checkedListBox = new CheckedListBox
            {
                BackColor = System.Drawing.SystemColors.Control,
                BorderStyle = System.Windows.Forms.BorderStyle.None,
                Location = new Point(20, 20)
            };

            for (int i = 0; i < chart1.Series.Count; i++)
            {

                checkedListBox.Items.Insert(i, chart1.Series[i].Name);
                checkedListBox.Height += checkedListBox.GetItemHeight(i);
                if (chart1.Series[i].Enabled)
                {
                    checkedListBox.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    checkedListBox.SetItemCheckState(i, CheckState.Unchecked);
                }

            }
            checkedListBox.MouseUp += CheckedListBox_MouseUp;
            form1.Controls.Add(checkedListBox);

            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (chart1.Annotations.Count > 0)
            {

                chart1.Annotations.Clear();

                if (form2.Created)
                {
                    form2.Close();
                }
                return;

            }

            double anchorX = chart1.ChartAreas[0].AxisX.Maximum / 2;
            ruler = new VerticalLineAnnotation
            {
                Name = "Ruler",
                AxisX = chart1.ChartAreas[0].AxisX,
                AxisY = chart1.ChartAreas[0].AxisY,
                IsSizeAlwaysRelative = true,
                AnchorX = anchorX,
                IsInfinitive = true,
                ClipToChartArea = chart1.ChartAreas[0].Name,
                AllowMoving = true,
                LineColor = Color.Black,
                LineWidth = 1,
                LineDashStyle = ChartDashStyle.Solid
            };

            chart1.Annotations.Add(ruler);


            RenderDataGridView(anchorX);



        }

        private void RenderDataGridView(double x)
        {

            form2 = new Form
            {
                Text = "Ruler",
                ShowIcon = false,
                AutoSize = true,
                TopMost = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(chart1.Left, chart1.Top + chart1.Height)
            };


            dataGridView1 = new DataGridView
            {
                BackgroundColor = System.Drawing.SystemColors.Window,
                ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                Name = "dataGridView1",
                AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill,
                AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells,
                BorderStyle = System.Windows.Forms.BorderStyle.None,
                ReadOnly = true,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                AllowDrop = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToOrderColumns = false,
            };

            dt = new DataTable();
            dt.Columns.Add("Trend");
            dt.Columns.Add("X");
            dt.Columns.Add("Y");
            foreach (var trend in chart1.Series)
            {

                if (trend.Enabled)
                {

                    DataPoint p = GetRulerPoint(x, trend);
                    dt.Rows.Add(new object[] { trend.Name, p.XValue, p.YValues[0] });


                }

            }
            dataGridView1.DataSource = dt;
            form2.Controls.Add(dataGridView1);
            form2.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            form2.Show();


        }
        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            chart1.Annotations.Clear();
        }

        private void CheckedListBox_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                chart1.Series[i].Enabled = checkedListBox.GetItemChecked(i);
            };

            //If ruler active, update dataGridView
            if (chart1.Annotations.Count > 0)
            {

                dt.Rows.Clear();
                foreach (var trend in chart1.Series)
                {
                    DataPoint pPrev = GetRulerPoint(ruler.X, trend);
                    if (trend.Enabled) dt.Rows.Add(new object[] { trend.Name, pPrev.XValue, pPrev.YValues[0] });

                }
                dataGridView1.DataSource = dt;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(0);
            chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset(0);
        }

        private void chart1_AnnotationPositionChanging(object sender, AnnotationPositionChangingEventArgs e)
        {

            dt.Rows.Clear();
            foreach (var trend in chart1.Series)
            {
                DataPoint point = GetRulerPoint(e.NewLocationX, trend);
                if (trend.Enabled) dt.Rows.Add(new object[] { trend.Name, point.XValue, point.YValues[0] });
            }

            dataGridView1.DataSource = dt;


        }

        private DataPoint GetRulerPoint(double ruler, Series trend)
        {

            DataPoint point;

            if (trend.Points.Count > 0)
            {
                point = trend.Points.Select(x => x)
                                        .Where(x => x.XValue >= ruler)
                                        .DefaultIfEmpty(trend.Points.First()).First();
            }
            else
            {
                point = new DataPoint(0, 0);
            }



            return point;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Axis ax = chart1.ChartAreas[0].AxisX;
            Axis ay = chart1.ChartAreas[0].AxisY;
            double f = 1.2;

            ax.ScaleView.Size = double.IsNaN(ax.ScaleView.Size) ?
                                (ax.Maximum - ax.Minimum) / f : ax.ScaleView.Size /= f;
            ay.ScaleView.Size = double.IsNaN(ay.ScaleView.Size) ?
                                (ay.Maximum - ay.Minimum) / f : ay.ScaleView.Size /= f;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Axis ax = chart1.ChartAreas[0].AxisX;
            Axis ay = chart1.ChartAreas[0].AxisY;
            double f = 1.2;

            ax.ScaleView.Size = double.IsNaN(ax.ScaleView.Size) ?
                                ax.Maximum : ax.ScaleView.Size *= f;
            if (ax.ScaleView.Size > ax.Maximum - ax.Minimum)
            {
                ax.ScaleView.Size = ax.Maximum;
                ax.ScaleView.Position = 0;
            }

            ay.ScaleView.Size = double.IsNaN(ay.ScaleView.Size) ?
                                ay.Maximum : ay.ScaleView.Size *= f;
            if (ay.ScaleView.Size > ay.Maximum - ay.Minimum)
            {
                ay.ScaleView.Size = ay.Maximum;
                ay.ScaleView.Position = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            var ca = chart1.ChartAreas[0];

            ca.CursorX.IsUserSelectionEnabled = true;
            ca.CursorY.IsUserSelectionEnabled = true;
            chart1.Cursor = System.Windows.Forms.Cursors.Cross;
        }

        private void chart1_AxisViewChanged(object sender, ViewEventArgs e)
        {
            var ca = chart1.ChartAreas[0];
            ca.CursorX.IsUserSelectionEnabled = false;
            ca.CursorY.IsUserSelectionEnabled = false;
            chart1.Cursor = System.Windows.Forms.Cursors.Default;
        }
    }
}



