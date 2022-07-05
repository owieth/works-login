package ponggame;

public class Main {
    public static void main(String[] args) {
        Gui gui = new Gui();
        new Movement();
        new GegnerMovement();
        new BallMovement();
        new BallCollision();

        gui.create();
    }
}
