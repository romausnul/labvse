using System.Windows;
using System.Windows.Media.Animation;

//====================================================
// Описание работы классов и методов исходника на:
// https://www.interestprograms.ru
// Исходные коды программ и игр
//====================================================

namespace WpfAnimation.MyCode
{
    class CommonMembers
    {
        public readonly Storyboard storyboard = new Storyboard();
        protected readonly FrameworkElement parent;

        public CommonMembers(FrameworkElement parent) => this.parent = parent;
    }
}
