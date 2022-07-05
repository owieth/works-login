package game;

import java.util.concurrent.ThreadLocalRandom;

public class GameMaster {

    public static final int ZELLEN = 512;
    public static boolean[][] zellenArray = new boolean[ZELLEN][ZELLEN];

    int startZellen = 10000;
    static int gen = 0;

    public void setup() {
        for (int i = 0; i < startZellen; i++) {
            int x = random(0, ZELLEN);
            int y = random(0, ZELLEN);

            zellenArray[x][y] = true;
        }
    }

    public static void nextGeneration() {
        gen++;
        System.out.println("Generation: " + gen);

        for (int x = 0; x < ZELLEN; x++) {
            for (int y = 0; y < ZELLEN; y++) {
                int n = nachbaren(x, y);

                if (n == 3 && !zellenArray[x][y]) {
                    zellenArray[x][y] = true;
                }

                if (n < 2) {
                    zellenArray[x][y] = false;
                }

                if (n == 2 || n == 3) {
                    //
                }

                if (n > 3) {
                    zellenArray[x][y] = false;
                }
            }
        }
    }

    public static int nachbaren(int x, int y) {
        int count = 0;

        //Nachbar-Felder
        int[] xoff = {1, 1, 0, -1, -1, -1, 0, 1};
        int[] yoff = {0, 1, 1, 1, 0, -1, -1, -1};

        for (int i = 0; i < 8; i++) {
            try {
                if (zellenArray[x + xoff[i]][y + yoff[i]]) {
                    count++;
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }

        return count;
    }

    public static int random(int min, int max) {
        return ThreadLocalRandom.current().nextInt(min, max);
    }
}
