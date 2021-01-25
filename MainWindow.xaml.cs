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

namespace DiscordExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtThing_TextChanged(object sender, TextChangedEventArgs e)
        {
            RTB.Document.Blocks.Clear();
            string longThing = txtThing.Text;
            //stolen from: https://docs.microsoft.com/en-us/dotnet/desktop/wpf/controls/richtextbox-overview?view=netframeworkdesktop-4.8
            FlowDocument myFlowDoc = new FlowDocument();
            Run myRun = new Run("This is flow content and you can ");
            Bold myBold = new Bold(new Run($"edit me, {longThing}"));

            Paragraph myParagraph = new Paragraph();
            myParagraph.Inlines.Add(myRun);
            myParagraph.Inlines.Add(myBold);

            myFlowDoc.Blocks.Add(myParagraph);
            RTB.Document = myFlowDoc;
        }
}   }
