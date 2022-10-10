using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cha
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();          
            Watch();
        }
        bool work=true;
        DateTime date = DateTime.Now.Date;   
        public async void Watch()
        {
            DateTim.Text = date.ToString("M");
            while (work==true)
            {
                Tim.Text = DateTime.Now.ToString("T");
                if(date != DateTime.Now.Date)
                {
                    date = DateTime.Now.Date;
                    DateTim.Text = date.ToString("M");

                }
                await Task.Delay(1000);
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}