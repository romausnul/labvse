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
    class BorderAnimation : CommonMembers
    {

        public BorderAnimation(FrameworkElement parent) : base(parent) 
        {
            storyboard.Completed += Storyboard_Completed;
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            // Очищаем раскадровку по завершении анимации.
            storyboard.Children.Clear();
        }

        public void BeginAnimation(Border border, bool reverse)
        {
            double speed = 0.4;
            double bt = 30;

            // Задержка запусков отдельных линий времени анимации.
            double delay = 1.5;

            // Появление от первой
            var tnLeft = new ThicknessAnimation
            {
                From = new Thickness(0, 0, 0, 0),
                To = new Thickness(bt, 0, 0, 0),
                Duration = new Duration(TimeSpan.FromSeconds(speed))

            };
            Storyboard.SetTargetName(tnLeft, border.Name);
            Storyboard.SetTargetProperty(tnLeft, new PropertyPath(Border.BorderThicknessProperty));
            storyboard.Children.Add(tnLeft);


            var tnTop = new ThicknessAnimation
            {
                From = new Thickness(bt, 0, 0, 0),
                To = new Thickness(bt, bt, 0, 0),
                Duration = new Duration(TimeSpan.FromSeconds(speed)),
                BeginTime = TimeSpan.FromSeconds(speed)
            };
            Storyboard.SetTargetName(tnTop, border.Name);
            Storyboard.SetTargetProperty(tnTop, new PropertyPath(Border.BorderThicknessProperty));
            storyboard.Children.Add(tnTop);


            var tnRight = new ThicknessAnimation
            {
                From = new Thickness(bt, bt, 0, 0),
                To = new Thickness(bt, bt, bt, 0),
                Duration = new Duration(TimeSpan.FromSeconds(speed)),
                BeginTime = TimeSpan.FromSeconds(speed * 2)

            };
            Storyboard.SetTargetName(tnRight, border.Name);
            Storyboard.SetTargetProperty(tnRight, new PropertyPath(Border.BorderThicknessProperty));
            storyboard.Children.Add(tnRight);


            var tnBottom = new ThicknessAnimation
            {
                From = new Thickness(bt, bt, bt, 0),
                To = new Thickness(bt, bt, bt, bt),
                Duration = new Duration(TimeSpan.FromSeconds(speed)),
                BeginTime = TimeSpan.FromSeconds(speed * 3)

            };
            Storyboard.SetTargetName(tnBottom, border.Name);
            Storyboard.SetTargetProperty(tnBottom, new PropertyPath(Border.BorderThicknessProperty));
            storyboard.Children.Add(tnBottom);



            // Второй круг - исчезновения бордюра.
            // reverse определяет вид исчезновения: по кругу или обратно по кругу
            if (reverse == false)
            {
                // Исчезновение начиная с первой.
                tnLeft = new ThicknessAnimation
                {
                    From = new Thickness(bt, bt, bt, bt),
                    To = new Thickness(0, bt, bt, bt),
                    Duration = new Duration(TimeSpan.FromSeconds(speed)),
                    BeginTime = TimeSpan.FromSeconds(speed * 4 * delay)

                };
                Storyboard.SetTargetName(tnLeft, border.Name);
                Storyboard.SetTargetProperty(tnLeft, new PropertyPath(Border.BorderThicknessProperty));
                storyboard.Children.Add(tnLeft);


                tnTop = new ThicknessAnimation
                {
                    From = new Thickness(0, bt, bt, bt),
                    To = new Thickness(0, 0, bt, bt),
                    Duration = new Duration(TimeSpan.FromSeconds(speed)),
                    BeginTime = TimeSpan.FromSeconds(speed * 5 * delay)

                };
                Storyboard.SetTargetName(tnTop, border.Name);
                Storyboard.SetTargetProperty(tnTop, new PropertyPath(Border.BorderThicknessProperty));
                storyboard.Children.Add(tnTop);


                tnRight = new ThicknessAnimation
                {
                    From = new Thickness(0, 0, bt, bt),
                    To = new Thickness(0, 0, 0, bt),
                    Duration = new Duration(TimeSpan.FromSeconds(speed)),
                    BeginTime = TimeSpan.FromSeconds(speed * 6 * delay)

                };
                Storyboard.SetTargetName(tnRight, border.Name);
                Storyboard.SetTargetProperty(tnRight, new PropertyPath(Border.BorderThicknessProperty));
                storyboard.Children.Add(tnRight);


                tnBottom = new ThicknessAnimation
                {
                    From = new Thickness(0, 0, 0, bt),
                    To = new Thickness(0, 0, 0, 0),
                    Duration = new Duration(TimeSpan.FromSeconds(speed)),
                    BeginTime = TimeSpan.FromSeconds(speed * 7 * delay)

                };
                Storyboard.SetTargetName(tnBottom, border.Name);
                Storyboard.SetTargetProperty(tnBottom, new PropertyPath(Border.BorderThicknessProperty));
                storyboard.Children.Add(tnBottom);
            }
            else
            {
                storyboard.AutoReverse = true;
            }

            storyboard.Begin(parent);
        }
    }
}
