using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

//====================================================
// Описание работы классов и методов исходника на:
// https://www.interestprograms.ru
// Исходные коды программ и игр
//====================================================

namespace WpfAnimation.MyCode
{
    class OpacityAnimation : CommonMembers
    {
        private FrameworkElement element;


        public OpacityAnimation(Canvas parent) : base(parent) { }



        private void Vanish()
        {
            double time = 0.5;

            var opacity = new DoubleAnimation
            {
                From = 1.0,
                To = 0.0,
                Duration = new Duration(TimeSpan.FromSeconds(time))
            };

            opacity.Completed += Opacity_Completed;

            element.BeginAnimation(UIElement.OpacityProperty, opacity);
        }


        private void Opacity_Completed(object sender, EventArgs e)
        {
            Moving();
            Emersion();
        }


        public void Start(FrameworkElement element)
        {
            this.element = element;

            Vanish();
        }


        readonly Random random = new Random();
        void Moving()
        {
            double x = random.Next(0, (int)(parent.Width - element.ActualWidth));
            double y = random.Next(0, (int)(parent.Height - element.ActualHeight));

            Canvas.SetLeft(element, x);
            Canvas.SetTop(element, y);
        }


        // Всплытие из глубины окна приложения.
        void Emersion()
        {
            double time = 0.3;
            double delay = 1;

            var opacity = new DoubleAnimation
            {
                From = 0.0,
                To = 1.0,
                Duration = new Duration(TimeSpan.FromSeconds(time)),
                BeginTime = TimeSpan.FromSeconds(delay)
            };

            element.BeginAnimation(Button.OpacityProperty, opacity);
        }
    }
}
