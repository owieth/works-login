package gui;

import game.Snake;

import javax.swing.*;
import java.awt.*;

public class Draw extends JLabel {

    Point point;

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        Graphics2D graphics2D = (Graphics2D) g;

        graphics2D.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_OFF);

        //Background
        g.setColor(Color.LIGHT_GRAY);
        g.fillRect(0, 0, Gui.getWidth(), Gui.getHeight());

        //Snake Tail
        g.setColor(new Color(51,204,51));
        for (int i = 0; i < Snake.tails.size(); i++) {
            point = Snake.point(Snake.tails.get(i).getX(), Snake.tails.get(i).getY());
            g.fillRect(point.x, point.y, 32, 32);
        }

        //Snake Head
        g.setColor(new Color(0, 153, 0));
        point = Snake.point(Snake.head.getX(), Snake.head.getY());
        g.fillRect(point.x, point.y, 32, 32);

        //Pickup
        g.setColor(new Color(204, 51, 0));
        point = Snake.point(Snake.pickUp.getX(), Snake.pickUp.getY());
        g.fillRect(point.x, point.y, 32, 32);

        //Grid (Spielfeld)
        g.setColor(Color.GRAY);
        for (int i = 0; i < 16; i++) {
            for (int j = 0; j < 16; j++) {
                g.drawRect(i * 32 + Gui.getXoff(), j * 32 + Gui.getYoff(), 32, 32);
            }
        }

        //Border
        g.setColor(Color.BLACK);
        g.drawRect(Gui.getXoff(), Gui.getYoff(), 512, 512);

        g.setFont(new Font("Arial", Font.BOLD, 20));
        g.drawString("Score: " + Snake.score, 655, 25);
        g.drawString("Best: " + Snake.bestscore, 655, 50);
        repaint();
    }
}
