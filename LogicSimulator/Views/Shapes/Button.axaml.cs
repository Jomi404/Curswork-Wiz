using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Input;
using Avalonia.Media;
using LogicSimulator.Models;
using System.ComponentModel;

namespace LogicSimulator.Views.Shapes {
    public partial class Button: GateBase, IGate, INotifyPropertyChanged {
        public override int TypeId => 6;

        public override UserControl GetSelf() => this;
        protected override IGate GetSelfI => this;
        protected override int[][] Sides => new int[][] {
            System.Array.Empty<int>(),
            System.Array.Empty<int>(),
            new int[] { 1 },
            System.Array.Empty<int>()
        };

        protected override void Init() => InitializeComponent();

        /*
         * Обработка размеров внутренностей
         */

        public double ButtonSize => width.Min(height) - BodyStrokeSize.Left * 5.5;

        /*
         * Мозги
         */

        bool my_state = false;

        private void Press(object? sender, PointerPressedEventArgs e) {
            if (e.Source is not Ellipse button) return;
            my_state = true;
            button.Fill = new SolidColorBrush(Color.Parse("#8B0000"));
        }
        private void Release(object? sender, PointerReleasedEventArgs e) {
            if (e.Source is not Ellipse button) return;
            my_state = false;
            button.Fill = new SolidColorBrush(Color.Parse("#DC143C"));
        }

        public void Brain(ref bool[] ins, ref bool[] outs) => outs[0] = my_state;
    }
}
