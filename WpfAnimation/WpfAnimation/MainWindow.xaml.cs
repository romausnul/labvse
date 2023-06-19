using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using WpfAnimation.MyCode;

//====================================================
// Описание работы классов и методов исходника на:
// https://www.interestprograms.ru
// Исходные коды программ и игр
//====================================================

namespace WpfAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly GradientAnimation gradientAnimation;
        private readonly BorderAnimation borderAnimation;
        private readonly OpacityAnimation opacityAnimation;
        private readonly ColorBrushAnimation colorAnimationK;

        public MainWindow()
        {
            InitializeComponent();

            gradientAnimation = new GradientAnimation(this);
            borderAnimation = new BorderAnimation(this);
            opacityAnimation = new OpacityAnimation(canvasForOpacity);
            colorAnimationK = new ColorBrushAnimation(this);
        }



        #region === UIElement.BeginAnimation ===

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            opacityAnimation.Start(btnStart);
        }

        private void gridCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            canvasForOpacity.Width = gridForOpacity.ActualWidth;
            canvasForOpacity.Height = gridForOpacity.RowDefinitions[1].ActualHeight;
        }

        #endregion


        #region === ColorBrushAnimation === 

        private void TabItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var color1 = Color.FromRgb(255, 0, 0);
            var color2 = Color.FromRgb(0, 200, 0);
            var color3 = Color.FromRgb(0, 0, 255);
            var color4 = Color.FromRgb(255, 255, 0);

            colorAnimationK.ColorRectangleAnimation(rectColor1, color1, color2, color3, color4);
            colorAnimationK.ColorRectangleAnimation(rectColor2, color2, color3, color4, color1);
            colorAnimationK.ColorRectangleAnimation(rectColor3, color3, color4, color1, color2);
            colorAnimationK.ColorRectangleAnimation(rectColor4, color4, color1, color2, color3);

            //Title = "Количество элементов в раскадровке - " + colorAnimationK.storyboard.Children.Count.ToString();
        }

        #endregion


        #region === PointAnimation === 

        private void startGradient_Click(object sender, RoutedEventArgs e)
        {
            gradientAnimation.Start(rectGradient);
            gradientAnimation.Start(rectGradientCopy);

            //Title = "Количество элементов в раскадровке - " + gradientAnimation.storyboard.Children.Count.ToString();
        }

        private void stopGradient_Click(object sender, RoutedEventArgs e)
        {
            gradientAnimation.Stop();
        }

        private void pauseGradient_Click(object sender, RoutedEventArgs e)
        {
            gradientAnimation.PauseResume();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Title = "Статус - " + gradientAnimation.storyboard.GetCurrentState(this).ToString();
            //Title += ", Пауза - " + gradientAnimation.storyboard.GetIsPaused(this).ToString();
        }

        #endregion


        #region === ThicknessAnimation === 

        private void rectBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            borderAnimation.BeginAnimation(border1, false);

            //Title = borderAnimation.storyboard.Children.Count.ToString();
        }

        #endregion





    }
}
