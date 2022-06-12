using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
  public partial class Chart : Form
  {
    public Chart()
    {
      InitializeComponent();
    }

    private void Chart_Load(object sender, EventArgs e)
    {
      // TODO: 이 코드는 데이터를 'dataDataSet1.Q1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
      this.q1TableAdapter1.Fill(this.dataDataSet1.Q1);
      // TODO: 이 코드는 데이터를 'dataDataSet.Q1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
      this.q1TableAdapter.Fill(this.dataDataSet.Q1);
      pieChart1.LegendLocation = LegendLocation.Bottom;
    }
    Func<ChartPoint, string> labelPoint = chartpoint => String.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
    private void button1_Click(object sender, EventArgs e)
    {
      SeriesCollection series = new SeriesCollection();
      foreach (var obj in dataDataSet.Q1)
        series.Add(new PieSeries() { Title = obj.ANSWER.ToString(), Values = new ChartValues<int> { obj.ANSWER }, DataLabels = true, LabelPoint = labelPoint});
      pieChart1.Series = series;
    }
  }
}
