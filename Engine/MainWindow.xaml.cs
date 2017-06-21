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
using System.Windows.Threading;

namespace TestNewEngineWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           /* NewEngine.SoundIO.SoundRecorder.Instance.StartRecording();
            NewEngine.NewEngineAPI.Instance.mouseChangedEvent += Instance_mouseChangedEvent;
            NewEngine.NewEngineAPI.Instance.newDiffEvent += Instance_newDiffEvent;
            screenWidth = SystemParameters.PrimaryScreenWidth;
            screenHeight = SystemParameters.PrimaryScreenHeight;*/
        }

        double screenWidth;
        double screenHeight;


        double x;
        double y;
        double z;
        private void Instance_newDiffEvent(NewEngine.NewEngineAPI.Diff3D diff3d)
        {
            try
            {
                Application.Current.Dispatcher.BeginInvoke(
    DispatcherPriority.Background,
    new Action(() =>
    {
        x = Math.Max(0, Math.Min(screenWidth, x + diff3d.X));
        y = Math.Max(0, Math.Min(screenHeight, y + diff3d.Y));
        z = Math.Max(0, Math.Min(screenHeight, z + diff3d.Z));

        recX.Width = Math.Max(0, Math.Min(screenWidth/2, x + diff3d.X));
        recY.Width = Math.Max(0, Math.Min(screenWidth / 2, y + diff3d.Y));
        recZ.Width = Math.Max(0, Math.Min(screenWidth / 2, z + diff3d.Z));

        if (checkBox.IsChecked.Value)
        {
            NewEngine.Tools.MouseOperations.SetCursorPosition((int)x, (int)y);
        }


    })); }
            catch
            {
             
            }
        }

        private void Instance_mouseChangedEvent(NewEngine.NewEngineAPI.MouseEvent mouseEvent)
        {
            Application.Current.Dispatcher.BeginInvoke(
DispatcherPriority.Background,
new Action(() =>
{



label.Content = mouseEvent;
            if (checkBox.IsChecked.Value)
            {
                switch (mouseEvent)
                {
                    case NewEngine.NewEngineAPI.MouseEvent.leftDown:
                        NewEngine.Tools.MouseOperations.MouseEvent(NewEngine.Tools.MouseOperations.MouseEventFlags.LeftDown);
                        break;
                    case NewEngine.NewEngineAPI.MouseEvent.leftUp:
                        NewEngine.Tools.MouseOperations.MouseEvent(NewEngine.Tools.MouseOperations.MouseEventFlags.LeftUp);
                        break;
                    case NewEngine.NewEngineAPI.MouseEvent.rightDown:
                        NewEngine.Tools.MouseOperations.MouseEvent(NewEngine.Tools.MouseOperations.MouseEventFlags.RightDown);
                        break;
                    case NewEngine.NewEngineAPI.MouseEvent.rightUp:
                        NewEngine.Tools.MouseOperations.MouseEvent(NewEngine.Tools.MouseOperations.MouseEventFlags.RightUp);
                        break;
                }
            }

}));

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (NewEngine.DataModels.MultiFramesProcessor.currentFreqType == NewEngine.Tools.FrequiecyClassification.FrequencyType.noneClick)
            {
                NewEngine.Config.Pointer3DParams.nonClickFrequiency = NewEngine.DataModels.MultiFramesProcessor.currentFrequency;
            }
            if (NewEngine.DataModels.MultiFramesProcessor.currentFreqType == NewEngine.Tools.FrequiecyClassification.FrequencyType.leftClick)
            {
                NewEngine.Config.Pointer3DParams.leftClickFrequiency = NewEngine.DataModels.MultiFramesProcessor.currentFrequency;
            }
            if (NewEngine.DataModels.MultiFramesProcessor.currentFreqType == NewEngine.Tools.FrequiecyClassification.FrequencyType.rightClick)
            {
                NewEngine.Config.Pointer3DParams.rightClickFrequiency = NewEngine.DataModels.MultiFramesProcessor.currentFrequency;
            }
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked.Value)
            {
                //WindowState = WindowState.Minimized;
                this.Hide();
                PPAD pp = new PPAD();
                pp.Show();
            }
        }
    }
}
