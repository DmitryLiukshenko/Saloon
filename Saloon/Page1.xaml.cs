using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Saloon
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

            List<Services> servicesList = new List<Services>
            {
                new Services {Title = "Ламинирование бровей", Cost = "1000 рублей", Description = "Что-то очень интересное", Duration = "3 часа"},
                new Services { Title = "Наращевание ногтей", Cost = "750 рублей", Description = "Что-то очень неинтересное", Duration = "2 часа" },
                new Services { Title = "Окрашивание волос", Cost = "2500 рублей", Description = "Что-то очень интересное", Duration = "30 минут"},
                new Services { Title = "Маникюр", Cost = "450 рублей", Description = "Что-то очень интересное", Duration = "1 час" },
                new Services { Title = "Ламинирование бровей 2", Cost = "1000 рублей", Description = "Что-то очень интересное", Duration = "45 минут" },
                new Services {Title = "Услуга 1", Cost = "1000 рублей", Description = "Что-то очень интересное", Duration = "3 часа"},
                new Services { Title = "Услуга 2", Cost = "750 рублей", Description = "Что-то очень неинтересное", Duration = "2 часа" },
                new Services { Title = "Услуга 3", Cost = "1500 рублей", Description = "Что-то очень интересное", Duration = "30 минут"},
                new Services { Title = "Услуга 4", Cost = "750 рублей", Description = "Что-то очень интересное", Duration = "45 минут" }
            };
            DGContent.
            DGContent.ItemsSource = servicesList;
        }
    }
}
