package actions;

import gui.Gui;
import time.GameClock;

public class Main {

    public static void main(String[] args) {
        Gui gui = new Gui();
        GameClock gameClock = new GameClock();


        gui.create();
        gameClock.start();
    }
}
