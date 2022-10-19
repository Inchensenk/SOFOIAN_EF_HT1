using Prism.Commands;
using SOFOIAN_EF_HT1.MVVM.Core;
using SOFOIAN_EF_HT1.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SOFOIAN_EF_HT1.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<OrderModel> Orders { get; }

        public DelegateCommand ClickCommand { get; }

        public MainViewModel()
        {
            ClickCommand = new DelegateCommand(OnClick);

            Orders = new ObservableCollection<OrderModel>();
        }

        private void OnClick()
        {
            using (MyDbContext context = new MyDbContext())
            {
               
                OrderModel order1 = new OrderModel { Summ=52000.50};
                OrderModel order2 = new OrderModel { Summ = 125255.25 };
                OrderModel order3 = new OrderModel { Summ = 1000259.59 };
                OrderModel order4 = new OrderModel { Summ = 525455000.50 };
                OrderModel order5 = new OrderModel { Summ = 12524445.25 };
                OrderModel order6 = new OrderModel { Summ = 10005454259.59 };
                OrderModel order7 = new OrderModel { Summ = 5200444440.50 };
                OrderModel order8 = new OrderModel { Summ = 124545454545255.25 };
                OrderModel order9 = new OrderModel { Summ = 10002454545454459.59 };

                context.Orders.AddRange(order1, order2, order3, order4, order5, order6, order7, order8, order9);
                context.SaveChanges();

            }
        }

    }
}
