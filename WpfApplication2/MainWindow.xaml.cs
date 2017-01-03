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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        Calculator calculator = new Calculator();
        public MainWindow()
        {
            
            InitializeComponent();
            button1.Click += ButtonClick;
            button2.Click += ButtonClick;
            button3.Click += ButtonClick;
            button4.Click += ButtonClick;
            button5.Click += ButtonClick;
            button6.Click += ButtonClick;
            button7.Click += ButtonClick;
            button8.Click += ButtonClick;
            button9.Click += ButtonClick;
            button0.Click += ButtonClick;
            additionButton.Click += OperatorButtonClick;
            subtractionButton.Click += OperatorButtonClick;
            divideButton.Click += OperatorButtonClick;
            ACButton.Click += ACbutton_Click;
            equalsButton.Click += EqualsButton_Click;
            menuButton.Click += MenuButton_Click;
            textBox.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            calculator.Input = textBox.Text;
        }

        public void ButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            string number = (string)((Button)sender).Content;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = number;
            }
            else
            {
                textBox.Text += number;
            }
        }

        // operator method
        public void OperatorButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            calculator.UpdateOperator((string)((Button)sender).Content);
            textBox.Text = "";
        }

        public void ACbutton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
           textBox.Text = "";
           calculator.ResetVariables();
        }

        public void EqualsButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            bool secondOperandBeenChanged = calculator.SecondOperandBeenChanged;
            if (!secondOperandBeenChanged)
            {
                calculator.UpdateSecondOperand(textBox.Text);
            }
            
            int answer = calculator.DoCalculation();

            calculator.FirstOperand = answer;
            textBox.Text = answer.ToString();
        }

        // admittedly I do not really understand how this code works 
        public void MenuButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }
        
         // not able to differentiate between menu items at the moment, but I only have one so it doesn't matter
         private void MenuItem_Click(object sender, RoutedEventArgs e)
         {
             var abtWindow = new AboutWindow();
             abtWindow.Show();
         }

         // closes the current window
         private void CloseButton_Click(object sender, RoutedEventArgs e)
         {
             Close();
         }
    }

}
