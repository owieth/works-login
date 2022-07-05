package ponggame;

import java.util.Timer;
import java.util.TimerTask;

public class BallMovement {
    Timer timer;
    public static int ballDirX = 1, ballDirY = -1;

    public BallMovement() {
        timer = new Timer();
        timer.scheduleAtFixedRate(new TimerTask() {
            @Override
            public void run() {

                Gui.ballX += ballDirX;
                Gui.ballY += ballDirY;

            }
        }, 0, 4);
    }
}
