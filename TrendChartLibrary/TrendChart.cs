using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Timers;

namespace TrendChartLibrary
{



    public enum ChartStyle
    {
        Dark = 0,
        Light = 1,
    }


    public partial class TrendChart : UserControl
    {
        Random rnd = new Random();
        const int MAX_POINTS = 40;


        double iPoints = MAX_POINTS;

        int iIndex = 0;

        ChartStyle Style = ChartStyle.Dark;



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
            set
            {
                chart1.Height = value;
            }
        }


        #region M01-09
        public double M01
        {
            get
            {
                return chart1.Series[iIndex].Points[0].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[0].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M02
        {
            get
            {
                return chart1.Series[iIndex].Points[1].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[1].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M03
        {
            get
            {
                return chart1.Series[iIndex].Points[2].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[2].YValues[0] = value;
                 chart1.Invalidate();
            }

        }
        public double M04
        {
            get
            {
                return chart1.Series[iIndex].Points[3].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[3].YValues[0] = value;
                 chart1.Invalidate();
            }

        }
        public double M05
        {
            get
            {
                return chart1.Series[iIndex].Points[4].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[4].YValues[0] = value;
                 chart1.Invalidate();
            }

        }
        public double M06
        {
            get
            {
                return chart1.Series[iIndex].Points[5].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[5].YValues[0] = value;
                 chart1.Invalidate();
            }

        }
        public double M07
        {
            get
            {
                return chart1.Series[iIndex].Points[6].YValues[0];

            }

            set
            {
                chart1.Series[iIndex].Points[6].YValues[0] = value;
                 chart1.Invalidate();
            }

        }
        public double M08
        {
            get
            {
                return chart1.Series[iIndex].Points[7].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[7].YValues[0] = value;
                 chart1.Invalidate();
            }
        }
        public double M09
        {
            get
            {
                return chart1.Series[iIndex].Points[8].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[8].YValues[0] = value;
                 chart1.Invalidate();
            }


        }

        #endregion
        #region M10-19
        public double M10
        {
            get
            {
                return chart1.Series[iIndex].Points[9].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[9].YValues[0] = value;
                 chart1.Invalidate();
            }

        }
        public double M11
        {
            get
            {
                return chart1.Series[iIndex].Points[10].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[10].YValues[0] = value;
                 chart1.Invalidate();
            }

        }
        public double M12
        {
            get
            {
                return chart1.Series[iIndex].Points[11].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[11].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M13
        {
            get
            {
                return chart1.Series[iIndex].Points[12].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[12].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M14
        {
            get
            {
                return chart1.Series[iIndex].Points[13].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[13].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M15
        {
            get
            {
                return chart1.Series[iIndex].Points[14].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[14].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M16
        {
            get
            {
                return chart1.Series[iIndex].Points[15].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[15].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M17
        {
            get
            {
                return chart1.Series[iIndex].Points[16].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[16].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M18
        {
            get
            {
                return chart1.Series[iIndex].Points[17].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[17].YValues[0] = value;
                chart1.Invalidate();
            }
        }
        public double M19
        {
            get
            {
                return chart1.Series[iIndex].Points[18].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[18].YValues[0] = value;
                chart1.Invalidate();
            }


        }

        #endregion
        #region M20-29
        public double M20
        {
            get
            {
                return chart1.Series[iIndex].Points[19].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[19].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M21
        {
            get
            {
                return chart1.Series[iIndex].Points[20].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[20].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M22
        {
            get
            {
                return chart1.Series[iIndex].Points[21].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[21].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M23
        {
            get
            {
                return chart1.Series[iIndex].Points[22].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[22].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M24
        {
            get
            {
                return chart1.Series[iIndex].Points[23].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[23].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M25
        {
            get
            {
                return chart1.Series[iIndex].Points[24].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[24].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M26
        {
            get
            {
                return chart1.Series[iIndex].Points[25].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[25].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M27
        {
            get
            {
                return chart1.Series[iIndex].Points[26].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[26].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M28
        {
            get
            {
                return chart1.Series[iIndex].Points[27].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[27].YValues[0] = value;
                chart1.Invalidate();
            }
        }
        public double M29
        {
            get
            {
                return chart1.Series[iIndex].Points[28].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[28].YValues[0] = value;
                chart1.Invalidate();
            }


        }

        #endregion
        #region M30-39
        public double M30
        {
            get
            {
                return chart1.Series[iIndex].Points[29].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[29].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M31
        {
            get
            {
                return chart1.Series[iIndex].Points[30].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[30].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M32
        {
            get
            {
                return chart1.Series[iIndex].Points[31].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[31].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M33
        {
            get
            {
                return chart1.Series[iIndex].Points[32].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[32].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M34
        {
            get
            {
                return chart1.Series[iIndex].Points[33].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[33].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M35
        {
            get
            {
                return chart1.Series[iIndex].Points[34].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[34].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M36
        {
            get
            {
                return chart1.Series[iIndex].Points[35].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[35].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M37
        {
            get
            {
                return chart1.Series[iIndex].Points[36].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[36].YValues[0] = value;
                chart1.Invalidate();
            }

        }
        public double M38
        {
            get
            {
                return chart1.Series[iIndex].Points[37].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[37].YValues[0] = value;
                chart1.Invalidate();
            }
        }
        public double M39
        {
            get
            {
                return chart1.Series[iIndex].Points[38].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[38].YValues[0] = value;
                chart1.Invalidate();
            }


        }

        public double M40
        {
            get
            {
                return chart1.Series[iIndex].Points[39].YValues[0];
            }

            set
            {
                chart1.Series[iIndex].Points[39].YValues[0] = value;
                chart1.Invalidate();
            }


        }

        #endregion
        public ChartStyle ChartAreaStyle
        {
            get { return Style; }
            set
            {
                Style = value;
                switch (value)
                {
                    case ChartStyle.Dark:
                        chart1.ChartAreas[0].BackColor = System.Drawing.Color.Black;
                        chart1.ChartAreas[0].AxisX.InterlacedColor = System.Drawing.Color.White;
                        chart1.ChartAreas[0].AxisX.LineColor = System.Drawing.Color.White;
                        chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
                        chart1.ChartAreas[0].AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
                        chart1.ChartAreas[0].AxisY.InterlacedColor = System.Drawing.Color.White;
                        chart1.ChartAreas[0].AxisY.LineColor = System.Drawing.Color.White;
                        chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
                        chart1.ChartAreas[0].AxisY.MinorGrid.LineColor = System.Drawing.Color.Gray;
                        break;
                    case ChartStyle.Light:

                        chart1.ChartAreas[0].BackColor = System.Drawing.Color.White;
                        chart1.ChartAreas[0].AxisX.InterlacedColor = System.Drawing.Color.Black;
                        chart1.ChartAreas[0].AxisX.LineColor = System.Drawing.Color.Black;
                        chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
                        chart1.ChartAreas[0].AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
                        chart1.ChartAreas[0].AxisY.InterlacedColor = System.Drawing.Color.Black;
                        chart1.ChartAreas[0].AxisY.LineColor = System.Drawing.Color.Black;
                        chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Black;
                        chart1.ChartAreas[0].AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
                        break;
                    default:
                        break;
                }


            }

        }

        public bool ShowLegend
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

        public bool ShowCheckedListBox
        {

            get
            {

                return checkedListBox.Enabled;

            }

            set
            {
                checkedListBox.Enabled = value;
            }
        }

        public string TrendName
        {
            get { return chart1.Series[iIndex].Name; }
            set
            {
                chart1.Series[iIndex].Name = value;
                checkedListBox.Items.RemoveAt(iIndex);
                checkedListBox.Items.Insert(iIndex, value);
                if (chart1.Series[iIndex].Enabled)
                {
                    checkedListBox.SetItemCheckState(iIndex, CheckState.Checked);
                }
                else
                {
                    checkedListBox.SetItemCheckState(iIndex, CheckState.Unchecked);
                }

                chart1.Invalidate();
            }
        }

        public Color TrendColor
        {
            get { return chart1.Series[iIndex].Color; }
            set
            {
                chart1.Series[iIndex].Color = value;
                chart1.Invalidate();
            }
        }

        public string AxisXLabel
        {
            get { return chart1.ChartAreas[0].AxisX.Title; }
            set { chart1.ChartAreas[0].AxisX.Title = value; }
        }

        public string AxisYLabel
        {
            get { return chart1.ChartAreas[0].AxisY.Title; }
            set { chart1.ChartAreas[0].AxisY.Title = value; }
        }

        public string AddTrend
        {
            get
            {
                return "";
            }

            set
            {
                if (chart1.Series.IsUniqueName(value) && value != "")
                {
                    AddTrendToChart(value,Color.AliceBlue);
                    checkedListBox.Items.Add(value);
                    checkedListBox.SetItemCheckState(checkedListBox.Items.IndexOf(value), CheckState.Checked);
                    chart1.Invalidate();

                };



            }

        }

        public string RemoveTrend
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
                        checkedListBox.Items.Remove(value);
                        break;
                    }
                }
                chart1.Invalidate();
                ;

            }

        }

        public double TrendPoints
        {
            get { return iPoints; }
            set
            {
                iPoints = value;
                chart1.ChartAreas[0].AxisX.Maximum = value;
                chart1.Invalidate();

            }


        }
        public double YMaximum
        {
            get { return chart1.ChartAreas[0].AxisY.Maximum; }
            set
            {
                chart1.ChartAreas[0].AxisY.Maximum = value;
                chart1.Invalidate();

            }


        }

        public int TrendIndex

        {
            get
            {
                return iIndex;
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

                iIndex = Clamp(value, min, max);

            }
        }

        public int TrendCount

        {
            get
            {
                return chart1.Series.Count;
            }

        }

       


        void InitTrends()
        {
            foreach (var trend in chart1.Series)
            {
                trend.Points.Clear();
                for (int i = 0; i < iPoints; i++)
                {
                    trend.Points.AddY(rnd.Next(1200));
                }
                
            }

        }


        void RenderCheckedListItems()
        {

            checkedListBox.Items.Clear();

            for (int i = 0; i < chart1.Series.Count; i++)
            {

                checkedListBox.Items.Insert(i, chart1.Series[i].Name);
                checkedListBox.SetItemCheckState(i, CheckState.Checked);

            }
        }

        public void AddTrendToChart(string Name, Color color)
        {   
            Series trend = new Series();
            trend.Name = Name;
            trend.Color = color;
            trend.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            trend.BorderWidth = 1;
            trend.MarkerSize = 5;
            trend.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            trend.IsValueShownAsLabel = true;
            trend.ToolTip = "#VAL°";
            trend.LabelForeColor = color;
            trend.Enabled = true;
            
            for (int i = 0; i < iPoints; i++)
            {
                trend.Points.AddY( 0);
            }

            chart1.Series.Add(trend);

        }

        public static int Clamp(int value, int min, int max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        public TrendChart()
        {
            InitializeComponent();
        }


        private void CheckedListBox_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                chart1.Series[i].Enabled = checkedListBox.GetItemChecked(i);

                chart1.Series[i].Enabled = chart1.Series[i].Enabled;
            };
        }

        private void TrendChart_Load(object sender, EventArgs e)
        {

            //InitTrends();
            RenderCheckedListItems();
        }


    }

}
