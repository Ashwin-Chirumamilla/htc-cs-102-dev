using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApplication1
{
    class GameMovement
    {
        
        PongBall ball;

        MainWindow win;
        double x = 0, y = 0;
        public GameMovement(MainWindow win, PongBall ball, double x, double y)
        {
            this.win = win;
            this.ball = ball;
            this.x = x;
            this.y = y;
        }
        public void MoveBall()
        {
            win.Dispatcher.Invoke((Action)(() =>
            {
                x += ball.xVelocity;
                y += ball.yVelocity;
                Canvas.SetLeft(ball, x);
                Canvas.SetTop(ball, y);
            }));
        }
    }
}
