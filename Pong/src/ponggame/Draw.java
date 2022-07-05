package ponggame;

import javax.swing.*;
import java.awt.*;
import ponggame.Gui;

public class Draw extends JLabel {
    public static int playerPunkte = 0;
    public static int gegnerPunkte = 0;

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        Graphics2D g2d = (Graphics2D) g;
        g2d.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);

        g.setColor(Color.BLACK);
        g.fillRect(0, 0, Gui.WIDTH, Gui.HEIGHT);

        g.setColor(Color.WHITE);
        for (int i = 0; i <= 30; i++) {
            g.fillRect(Gui.WIDTH / 2 - 5, i * 20, 10, 10);
        }

        g.fillRect(Gui.Gegner1X, Gui.Gegner1Y, 25, 150);
        g.fillRect(Gui.Gegner2X, Gui.Gegner2Y, 25, 150);

        g.drawString("" + playerPunkte, Gui.WIDTH / 2 - 100, 75);
        g.drawString("" + gegnerPunkte, Gui.WIDTH / 2 + 100, 75);

        g.fillRect(Gui.ballX, Gui.ballY, 20, 20);

        repaint();
    }
}
