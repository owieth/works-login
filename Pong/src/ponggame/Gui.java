package ponggame;

import javax.swing.*;

public class Gui {

    JFrame jFrame;
    public static Draw draw;
    public static final int WIDTH = 800, HEIGHT = 600;
    public static int ballX = 200, ballY = 250;
    public static int Gegner1X = 20, Gegner1Y = 185, Gegner2X = 755, Gegner2Y = 185;

    public void create() {
        jFrame = new JFrame("Pong");
        jFrame.setSize(WIDTH, HEIGHT);
        jFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        jFrame.setLayout(null);
        jFrame.setResizable(false);
        jFrame.setLocationRelativeTo(null);
        jFrame.addKeyListener(new KeyHandler());
        jFrame.requestFocus();

        draw = new Draw();
        draw.setBounds(0,0, WIDTH, HEIGHT);
        draw.setVisible(true);
        jFrame.add(draw);

        jFrame.setVisible(true);
    }
}
