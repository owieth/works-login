package gui;

import actions.KeyHandler;

import javax.swing.*;
import javax.swing.plaf.basic.BasicTreeUI;
import java.awt.event.KeyAdapter;

public class Gui {
    JFrame jFrame;
    Draw draw;

    public static int width = 800, height = 600;
    public static int xoff = 10, yoff = 10;

    public void create(){
        jFrame = new JFrame("Snake");
        jFrame.setSize(width, height);
        jFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        jFrame.setResizable(false);
        jFrame.setLocationRelativeTo(null);
        jFrame.setLayout(null);
        jFrame.addKeyListener(new KeyHandler());

        draw = new Draw();
        draw.setBounds(0, 0, width, height);
        draw.setVisible(true);
        jFrame.add(draw);

        jFrame.requestFocus();
        jFrame.setVisible(true);

    }

    public static int getWidth() {
        return width;
    }

    public static int getHeight() {
        return height;
    }

    public static int getXoff() {
        return xoff;
    }

    public static int getYoff() {
        return yoff;
    }
}
