using COMP123_S2019_A5_301044883.Models;
using COMP123_S2019_A5_301044883.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301044883
{
    public static class Program
    {
        public static StartForm startForm;
        public static SplashForm splashForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;

        public static Product product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //instantiate all Forms
            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();

            product = new Product();

            Application.Run(splashForm);
        }
    }
}
