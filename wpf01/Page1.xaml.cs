using System.Windows;
using System.Windows.Controls;

namespace wpf01
{
    /// <summary>
    /// Page1.xaml の相互作用ロジック
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 選択したデータがPage2クラスがインスタンス化されるときに渡される
            Page2 page2 = new Page2(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(page2);
        }
    }
}
