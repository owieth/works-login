package ponggame;

import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class KeyHandler implements KeyListener {
    @Override
    public void keyTyped(KeyEvent e) {

    }

    @Override
    public void keyPressed(KeyEvent e) {
        if (e.getKeyCode() == KeyEvent.VK_UP) {
            Movement.moveup = true;
            System.out.println("up");
        } else if (e.getKeyCode() == KeyEvent.VK_DOWN) {
            Movement.movedown = true;
            System.out.println("down");
        }
    }

    @Override
    public void keyReleased(KeyEvent e) {
        if (e.getKeyCode() == KeyEvent.VK_UP) {
            Movement.moveup = false;
        } else if (e.getKeyCode() == KeyEvent.VK_DOWN) {
            Movement.movedown = false;
        }
    }
}
