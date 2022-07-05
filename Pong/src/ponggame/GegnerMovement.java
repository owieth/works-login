package ponggame;

import java.util.Timer;
import java.util.TimerTask;

public class GegnerMovement {
    Timer timer;


    public GegnerMovement() {
        timer = new Timer();
        timer.scheduleAtFixedRate(new TimerTask() {
            @Override
            public void run() {
                if (Gui.ballY == Gui.Gegner2Y) {

                } else if (Gui.ballY > Gui.Gegner2Y + 75) {
                    if (Gui.Gegner2Y <= Gui.HEIGHT - 200) {
                        Gui.Gegner2Y += 2;
                    }

                } else if (Gui.ballY < Gui.Gegner2Y + 75) {
                    if (Gui.Gegner2Y >= 20) {
                        Gui.Gegner2Y -= 2;
                    }
                }
            }
        }, 0, 6);
    }
}
