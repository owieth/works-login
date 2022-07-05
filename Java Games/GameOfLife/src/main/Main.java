package main;

import game.GameClock;
import game.GameMaster;
import gui.GUI;

public class Main {
    public static void main(String[] args) {
        GUI gui = new GUI();
        GameMaster gameMaster = new GameMaster();
        GameClock gameClock = new GameClock();

        gameMaster.setup();
        gui.create();
        gameClock.start();
    }
}
