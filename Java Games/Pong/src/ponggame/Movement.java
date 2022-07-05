package ponggame;

import java.util.Timer;
import java.util.TimerTask;

public class Movement {

    public static boolean moveup = false, movedown = false;
    Timer timer;

    public Movement() {
        timer = new Timer();
        timer.scheduleAtFixedRate(new TimerTask() {
            @Override
            public void run() {
                if (moveup) {
                    if (Gui.Gegner1Y >= 20) {
                        Gui.Gegner1Y -= 2;
                    }
                } else if (movedown) {
                    if (Gui.Gegner1Y <= Gui.HEIGHT - 200) {
                        Gui.Gegner1Y += 2;
                    }
                }
            }
        }, 0, 6);
    }
}
