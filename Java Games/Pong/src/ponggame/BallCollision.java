package ponggame;

import java.util.Timer;
import java.util.TimerTask;

public class BallCollision {

    Timer timer;

    public BallCollision() {
        timer = new Timer();
        timer.scheduleAtFixedRate(new TimerTask() {
            @Override
            public void run() {
                if(Gui.ballY + 50 >= Gui.HEIGHT){
                    BallMovement.ballDirY = -1;
                }

                if(Gui.ballY <= 0){
                    BallMovement.ballDirY = 1;
                }

                if(Gui.ballX + 20 >= Gui.WIDTH){
                    Gui.ballX = Gui.WIDTH / 2 - 10;
                    Gui.ballY = Gui.HEIGHT / 2 - 10;

                    BallMovement.ballDirX = -1;
                    Draw.playerPunkte += 1;
                }

                if(Gui.ballX <= 0){
                    Gui.ballX = Gui.WIDTH / 2 - 10;
                    Gui.ballY = Gui.HEIGHT / 2 - 10;

                    BallMovement.ballDirX = 1;
                    Draw.gegnerPunkte += 1;
                }

                //Ball trifft Schläger von Player 1
                if(Gui.ballX < Gui.Gegner1X + 25 && Gui.ballX > Gui.Gegner1X && Gui.ballY - 20 < Gui.Gegner1Y + 150 && Gui.ballY > Gui.Gegner1Y){
                    BallMovement.ballDirX = 1;
                }

                //Ball trifft Schläger von Player 2
                if(Gui.ballX < Gui.Gegner2X && Gui.ballX > Gui.Gegner2X - 25 && Gui.ballY - 20 < Gui.Gegner2Y + 150 && Gui.ballY > Gui.Gegner2Y){
                    BallMovement.ballDirX = -1;
                }
            }
        }, 0,5);
    }
}
