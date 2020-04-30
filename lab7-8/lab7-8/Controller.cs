using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace lab7_8
{
    class Controller: MainWindow
    {
        public void RunClock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            currentDateTextBlock.Text = DateTime.Now.ToString("dd");
            currentDayTextBlock.Text = DateTime.Now.ToString("dddd");
            currentMonthTextBlock.Text = DateTime.Now.ToString("MMMM, yyyy");
            currenTimeTextBlock.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
