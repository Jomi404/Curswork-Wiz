using Avalonia;
using Avalonia.Controls;

namespace LogicSimulator.Views.Shapes {
    public partial class AND_2: UserControl, IGate {
        public AND_2() {
            InitializeComponent();
            DataContext = this;
        }

        public Point GetPos() => new(Margin.Left, Margin.Top);

        public void Move(Point pos) {
            Margin = new(pos.X, pos.Y, 0, 0);
        }

        public void Resize(Size size) {
            throw new System.NotImplementedException();
        }
    }
}