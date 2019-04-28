using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Server_Restart_Final
{
    public class MoveItemControlViewModel
    {
        public UIElement Item { get; set; }
        public UIElement Container { get; set; }

        public MoveItemControlViewModel(UIElement item, UIElement container)
        {
            Item = item;
            Container = container;
            Item.PreviewMouseDown += Item_PreviewMouseDown;
            Item.PreviewMouseUp += Item_PreviewMouseUp;
            Item.PreviewMouseMove += Item_PreviewMouseMove;
        }
        
        private bool _isMoving;
        private Point? _buttonPosition;
        private double deltaX;
        private double deltaY;
        private TranslateTransform _currentTT;

        private void Item_PreviewMouseDown(object sender,EventArgs e)
        {
            if (_buttonPosition == null)
                _buttonPosition = Item.TransformToAncestor(Container).Transform(new Point(0, 0));
            var mousePosition = Mouse.GetPosition(Container);
            deltaX = mousePosition.X - _buttonPosition.Value.X;
            deltaY = mousePosition.Y - _buttonPosition.Value.Y;
            _isMoving = true;
        }

        private void Item_PreviewMouseUp(object sender,EventArgs e)
        {
            _currentTT = Item.RenderTransform as TranslateTransform;
            _isMoving = false;
        }

        private void Item_PreviewMouseMove(object sender,EventArgs e)
        {
            if (!_isMoving) return;

            var mousePoint = Mouse.GetPosition(Container);

            var offsetX = (_currentTT == null ? _buttonPosition.Value.X : _buttonPosition.Value.X - _currentTT.X) + deltaX - mousePoint.X;
            var offsetY = (_currentTT == null ? _buttonPosition.Value.Y : _buttonPosition.Value.Y - _currentTT.Y) + deltaY - mousePoint.Y;

            Item.RenderTransform = new TranslateTransform(-offsetX, -offsetY);
        }
    }
}
