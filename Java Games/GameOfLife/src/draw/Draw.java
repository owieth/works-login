package draw;

import game.GameMaster;
import gui.GUI;

import javax.swing.*;
import java.awt.*;

public class Draw extends JLabel {
    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        Graphics2D g2d = (Graphics2D) g;
        g2d.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_OFF);

        g.setColor(Color.RED);
        g.drawRect(9,9, GUI.WIDTH + 2, GUI.HEIGHT + 2);

        for (int x = 0; x < GameMaster.ZELLEN; x++) {
            for (int y = 0; y < GameMaster.ZELLEN; y++) {
                if(GameMaster.zellenArray[x][y]){
                    g.setColor(Color.BLACK);
                    g.drawRect(x + GUI.XOFF, y + GUI.YOFF, 1, 1);
                } else {
                    g.setColor(Color.WHITE);
                    g.drawRect(x + GUI.XOFF, y + GUI.YOFF, 1, 1);
                }
            }
        }

        repaint();
     }
}
