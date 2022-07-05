package com.example.rollaroundapp_projekt;

import android.content.SharedPreferences;
import android.graphics.Color;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.os.Bundle;
import android.os.Handler;
import android.support.constraint.ConstraintLayout;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.Toast;

import java.util.Timer;
import java.util.TimerTask;


public class GameActivity extends AppCompatActivity {

    SharedPreferences sharedPreferences;

    private SensorManager sensorManager;
    private Sensor accelerometerSensor;
    private SensorEventListener accelerometerEventListener;
    private SensorEvent sensorEvent;
    private ImageButton playerBall;
    private int boxY;
    private int boxX;
    private int boxSize;
    private ConstraintLayout frameGame;

    private Button gameButton1;
    private Button gameButton2;
    private Button gameButton3;
    private Button gameButton4;
    private int frameHeight;
    private int frameWidth;

    //Delay
    private Handler handler = new Handler();
    private Timer timer = new Timer();

    /**
     * @param savedInstanceState
     */
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.game);

        sharedPreferences = getSharedPreferences(MainActivity.PREFS, 0);
        int background = sharedPreferences.getInt("", MainActivity.COLOR_BALL);
        int mode = sharedPreferences.getInt("", MainActivity.DARKMODE);
        int boxes = sharedPreferences.getInt("", MainActivity.BOXES);

        sensorManager = (SensorManager) getSystemService(SENSOR_SERVICE);
        accelerometerSensor = sensorManager.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
        playerBall = findViewById(R.id.imageButtonBall);
        frameGame = findViewById(R.id.frameGame);
        gameButton1 = findViewById(R.id.gameButton1);
        gameButton2 = findViewById(R.id.gameButton2);
        gameButton3 = findViewById(R.id.gameButton3);
        gameButton4 = findViewById(R.id.gameButton4);
        frameGame.setBackgroundColor(sharedPreferences.getInt("", mode));

        //Log.i(MainActivity.COLOR_BALL, boxes);

        /*button1.setBackgroundColor(sharedPreferences.getInt(boxes, 1));
        button2.setBackgroundColor(sharedPreferences.getInt(boxes, 1));
        button3.setBackgroundColor(sharedPreferences.getInt(boxes, 1));
        button4.setBackgroundColor(sharedPreferences.getInt(boxes, 1));*/

        /*Diese if-Verzweigung ist dazu da den  Benutzer darauf hinzuweisen ob er keinen Gyroscope besitzt,
         die App wird direkt gschlossen.
          */
        if (accelerometerSensor == null) {
            Toast.makeText(this, "Dieses Android-Gerät hat keinen GyroSensor, darum können Sie dieses Spiel nicht spielen. ", Toast.LENGTH_LONG).show();
            finish();
        }
        boxX = 500;
        boxY = 500;
        //Bei diesem Timer durchläuft er alle 20 Sekunden die Methoden Changepos.
        timer.schedule(new TimerTask() {
            @Override
            public void run() {
                handler.post(new Runnable() {
                    @Override
                    public void run() {
                        changePos();
                    }
                });
            }
        }, 0, 20);

        //Dieser Timer hier wurde von Mirco programmiert.
        Timer gameTimer = new Timer();
        gameTimer.scheduleAtFixedRate(new GameTick(), 0, 10);
        accelerometerEventListener = new SensorEventListener() {

            @Override
            public void onSensorChanged(SensorEvent event) {
                sensorEvent = event;
            }

            @Override
            public void onAccuracyChanged(Sensor sensor, int accuracy) {

            }
        };
    }



    class GameTick extends TimerTask {
        @Override
        public void run() {
            GameActivity.this.runOnUiThread(new Runnable() {
                @Override
                public void run() {
                    frameHeight = frameGame.getHeight();
                    frameWidth = frameGame.getWidth();
                    boxY = (int) playerBall.getY();
                    boxSize = playerBall.getHeight();
                    /*Mit dieser IF-Verweigung bewege ich den Ball, ich schaue um wieviel sich das Handy neigt und bewege den Ball in diese Richtung.
                      Beim GyroScope ist es so das alle Richtungen in einem Array abgespeichert sind. Das erste element ist die Y-Achse, das Zweite die X-Achse
                      und das dritte das ich nicht brauche wäre die Z-Achse.*/
                    if (sensorEvent.values[1] > 2f) {                                                         //nach oben
                        playerBall.setBackgroundColor(Color.rgb(255, 255, 0));
                        boxY += 15;
                    } else if (sensorEvent.values[1] < -2F) {                                                 //nach unten
                        playerBall.setBackgroundColor(Color.rgb(255, 0, 255));
                        boxY -= 15;
                    } else if (sensorEvent.values[0] < -2F) {                                                 //nach links
                        playerBall.setBackgroundColor(Color.rgb(0, 222, 255));
                        boxX += 5;
                    } else if (sensorEvent.values[0] > 2F) {                                                  //nach rechts
                        playerBall.setBackgroundColor(Color.rgb(0, 222, 22));
                        boxX -= 5;
                    }
                }
            });
        }
    }

    @Override
    protected void onResume() {
        super.onResume();
        sensorManager.registerListener(accelerometerEventListener, accelerometerSensor, SensorManager.SENSOR_DELAY_FASTEST);
    }

    @Override
    protected void onPause() {
        super.onPause();
        sensorManager.unregisterListener(accelerometerEventListener);
    }

    /**
     *
     */
    public void changePos() {
//Diese Ganzen Verzweigungen hier sind dafür die Bergenzung da.
        if (boxY < 0) {
            boxY = 0;
        } else if (boxY > frameHeight - boxSize) {
            boxY = frameHeight - boxSize;
        } else if (boxX < 0) {
            boxX = 0;
        } else if (boxX > frameWidth - boxSize) {
            boxX = frameWidth - boxSize;
        }
        checkHit();
        playerBall.setX(boxX);
        playerBall.setY(boxY);
    }

    /**
     *
     */
    public void checkHit() {
        //Ich musste hier meine Buttons ihre Koordinaten abspeichern damit ich sie in einer else if Verzweigung abrufen kann.
        float gameButton1X = gameButton1.getX() - 100;
        float gameButton2X = gameButton2.getX() - 100;
        float gameButton3Y = gameButton3.getY() - 100;
        float gameButton4Y = gameButton4.getY() - 100;
        float gameButton1Y = gameButton1.getY() - 100;
        float gameButton2Y = gameButton2.getY() - 100;
        float gameButton3X = gameButton3.getX() - 100;
        float gameButton4X = gameButton4.getX() - 100;
//Hier ist die IF-Verzweigung die das verschwinden der Box macht.
        if (gameButton1X <= boxX && gameButton1Y <= boxY) {
            gameButton1.setVisibility(View.INVISIBLE);
        } else if (gameButton2X <= boxX && gameButton2Y <= boxY) {
            gameButton2.setVisibility(View.INVISIBLE);
        } else if (gameButton3Y <= boxY && gameButton3X <= boxX) {
            gameButton3.setVisibility(View.INVISIBLE);
        } else if (gameButton4Y <= boxY && gameButton4X <= boxX) {
            gameButton4.setVisibility(View.INVISIBLE);
        }
    }

}
