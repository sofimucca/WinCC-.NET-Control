using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TrendChartLibrary
{

    public enum ChartStyle
    {
        Dark = 0,
        Light = 1,
    }

    public partial class TrendChart : UserControl
    {

        int Index = 0;
        double X = 0;
        double Y = 0;

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

        public ChartStyle TrendChartAreaStyle
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

                return checkedListBox.Enabled;

            }

            set
            {
                checkedListBox.Enabled = value;
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
                if (checkedListBox.Items.Count > 0 && chart1.Series.Count > 0)
                {
                    chart1.Series[Index].Name = value;
                    checkedListBox.Items.RemoveAt(Index);
                    checkedListBox.Items.Insert(Index, value);
                    if (chart1.Series[Index].Enabled)
                    {
                        checkedListBox.SetItemCheckState(Index, CheckState.Checked);
                    }
                    else
                    {
                        checkedListBox.SetItemCheckState(Index, CheckState.Unchecked);
                    }


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

        public string TrendAxisYLabel
        {
            get { return chart1.ChartAreas[0].AxisY.Title; }
            set { chart1.ChartAreas[0].AxisY.Title = value; }
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
                    TrendAddSeries(value);


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
                        checkedListBox.Items.Remove(value);
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

                //chart1.Invalidate();
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

        public double TrendPointX
        {
            get { return X; }
            set { X = value; }

        }

        public double TrendPointY
        {
            get { return Y; }
            set { Y = value; }

        }

        public int TrendCount

        {
            get
            {
                return chart1.Series.Count;
            }

        }

        public int TrendInsertXY
        {
            get { return -1; }
            set
            {
                if (value >= 0) InsertXY(Index, value, X, Y);
            }
        }

        public bool TrendRefresh
        {
            get { return false; }
            set
            {
                if (value) chart1.Invalidate();
            }
        }


        void CheckedListItemsRefresh()
        {

            checkedListBox.Items.Clear();

            for (int i = 0; i < chart1.Series.Count; i++)
            {

                checkedListBox.Items.Insert(i, chart1.Series[i].Name);
                checkedListBox.SetItemCheckState(i, CheckState.Checked);

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


        private void CheckedListBox_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                chart1.Series[i].Enabled = checkedListBox.GetItemChecked(i);
            };
        }

        private void TrendChart_Load(object sender, EventArgs e)
        {

            CheckedListItemsRefresh();
        }

        private void TrendClearPoints(int i)
        {
            if (i < chart1.Series.Count)
            {
                chart1.Series[i].Points.Clear();

            }


        }

        private void InsertXY(int trendIndex, int pointIndex, double x, double y)
        {

            if (trendIndex < chart1.Series.Count)
            {
                if (pointIndex < chart1.Series[trendIndex].Points.Count)
                {
                    chart1.Series[trendIndex].Points[pointIndex].SetValueXY(x, y);
                }
                else
                {
                    chart1.Series[trendIndex].Points.AddXY(x, y);
                }

            }

        }


        private void TrendAddSeries(string trendName)
        {


            if (chart1.Series.IsUniqueName(trendName))
            {
                Series series = new Series
                {
                    ChartArea = "ChartArea1",
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    Legend = "Legend1",
                    MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle,
                    Name = trendName,
                    ToolTip = "(#VALX,#VALY)"

                };

                chart1.Series.Add(series);

                checkedListBox.Items.Add(trendName);
                checkedListBox.SetItemCheckState(checkedListBox.Items.IndexOf(trendName), CheckState.Checked);

            }

        }

        private void TrendClearSeries()
        {
            if (chart1.Series.Count > 0)
            {
                chart1.Series.Clear();
                checkedListBox.Items.Clear();
            }

        }



    }
}


