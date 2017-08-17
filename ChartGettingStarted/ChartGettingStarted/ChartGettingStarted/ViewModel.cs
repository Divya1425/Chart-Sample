using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartGettingStarted
{
    public class ViewModel
    {
        public ObservableCollection<ChartDataPoint> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<ChartDataPoint>()
            {
                 new ChartDataPoint ("Medical", 15.99),
                 new ChartDataPoint ("Housing", 8),
                 new ChartDataPoint ("Education", 15.87),
                 new ChartDataPoint ("Others", 60.14),
            };
        }
    }
}
