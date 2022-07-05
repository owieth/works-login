package com.example.rollaroundapp_projekt;


import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {
    public static final int COLOR_BALL = 1;
    public static final int DARKMODE = 0;
    public static final int BOXES = 4;
    public static final String PREFS = "PREFS" ;

    private SharedPreferences sharedPreferences;
    private SharedPreferences.Editor preferenceEditor;
    private SettingsActivity settingsActivity;


    /**
     * @param savedInstanceState
     * In der onCreate-Methoden werden den Variablen die Werte hinzugefügt
     * und die beiden Buttons bekommen ihre Funktion.
     */
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        settingsActivity = new SettingsActivity();

        sharedPreferences = getSharedPreferences(MainActivity.PREFS, 0);
        preferenceEditor = sharedPreferences.edit();
        preferenceEditor.putInt(settingsActivity.colorBall, COLOR_BALL);
        preferenceEditor.putInt(settingsActivity.darkMode, DARKMODE);
        preferenceEditor.putInt(settingsActivity.boxes, BOXES);
        preferenceEditor.apply();

        Button btn = (Button)findViewById(R.id.startGameButton);
        Button btn2 = (Button)findViewById(R.id.settingsButton);

        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(MainActivity.this, GameActivity.class));
            }
        });

        btn2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(MainActivity.this, SettingsActivity.class));
            }
        });

    }
    @Override
    protected void onResume() {
        super.onResume();
    }

    @Override
    protected void onPause() {
        super.onPause();
    }
}
