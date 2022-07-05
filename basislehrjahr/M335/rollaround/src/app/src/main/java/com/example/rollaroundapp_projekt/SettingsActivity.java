package com.example.rollaroundapp_projekt;

import android.content.SharedPreferences;
import android.graphics.Color;
import android.os.Bundle;
import android.support.constraint.ConstraintLayout;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Switch;


/**
 * Die Einstellungen von unserer App werden in dieser Klasse verwaltet.
 */
public class SettingsActivity extends AppCompatActivity  {
    private SharedPreferences sharedPreferences;
    private SharedPreferences.Editor preferenceEditor;

    private ConstraintLayout constraintLayout;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private RadioButton radioButton3;
    private RadioButton radioButton4;
    private RadioGroup radioGroup;

    private Switch settingsSwitch;

    private CheckBox checkBox1;
    private CheckBox checkBox2;
    private CheckBox checkBox3;
    private CheckBox checkBox4;

    public int color;
    public int mode;
    public int amountBoxes;

    public String colorBall = "colorBall";
    public String darkMode = "darkmode";
    public String boxes = "amountboxes";

    /**
     * @param savedInstanceState
     * Diese Methode wird direkt aufgerufen, wenn die Activity generiert wird
     */
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.settings);

        sharedPreferences = getSharedPreferences(MainActivity.PREFS, 0);
        preferenceEditor = sharedPreferences.edit();
        preferenceEditor.apply();

        color = sharedPreferences.getInt(colorBall, MainActivity.COLOR_BALL);
        mode = sharedPreferences.getInt(darkMode, MainActivity.DARKMODE);
        amountBoxes = sharedPreferences.getInt(boxes, MainActivity.BOXES);

        settingsSwitch = findViewById(R.id.switch1);
        constraintLayout = findViewById(R.id.test);
        radioButton1 = findViewById(R.id.radioButton1);
        radioButton2 = findViewById(R.id.radioButton2);
        radioButton3 = findViewById(R.id.radioButton3);
        radioButton4 = findViewById(R.id.radioButton4);

        radioGroup = findViewById(R.id.radioGroup);

        checkBox1 = findViewById(R.id.checkBox1);
        checkBox2 = findViewById(R.id.checkBox2);
        checkBox3 = findViewById(R.id.checkBox3);
        checkBox4 = findViewById(R.id.checkBox4);

        //Settings, die geändert wurden, werden wieder geladen, wenn der
        // Benutzer wieder in die Einstellungen zurückkehrt.
        loadSettings();

        //Hier wird der Hintergrund auf Schwarz gestellt, falls der Switch auf ON gestellt wurde.
        settingsSwitch.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if (isChecked) {
                    constraintLayout.setBackgroundColor(getResources().getColor(R.color.color_darkmode));
                    preferenceEditor.putInt(darkMode, 1);
                } else {
                    constraintLayout.setBackgroundColor(Color.TRANSPARENT);
                    preferenceEditor.putInt(darkMode, 0);
                }
            }
        });
    }

    /**
     * @param view
     * Diese Methode wird aufgerufen, wenn ein Radiobutton geklickt wird.
     */
    public void onRadioButtonClicked(View view) {
        if(radioGroup.getCheckedRadioButtonId() == R.id.radioButton1){
            constraintLayout.setBackgroundColor(Color.RED);
            preferenceEditor.putInt(colorBall, 1);
            preferenceEditor.apply();
        } else if(radioGroup.getCheckedRadioButtonId() == R.id.radioButton2){
            constraintLayout.setBackgroundColor(Color.BLUE);
            preferenceEditor.putInt(colorBall, 1);
            preferenceEditor.apply();
        } else if(radioGroup.getCheckedRadioButtonId() == R.id.radioButton3){
            constraintLayout.setBackgroundColor(Color.GREEN);
            preferenceEditor.putInt(colorBall, 1);
            preferenceEditor.apply();
        } else if(radioGroup.getCheckedRadioButtonId() == R.id.radioButton4){
            constraintLayout.setBackgroundColor(Color.MAGENTA);
            preferenceEditor.putInt(colorBall, 1);
            preferenceEditor.apply();
        }
    }


    /**
     * Diese Methode wird aufgerufen, wenn der Benutzer die View verlässt, aber später wieder
     * zurück kommt oder z.B. eine Nachricht eingeblendet wird.
     */
    @Override
    protected void onResume() {
        super.onResume();
        sharedPreferences.getInt(colorBall, color);
        sharedPreferences.getInt(darkMode, mode);
        sharedPreferences.getInt(boxes, amountBoxes);

        loadSettings();
    }

    /**
     * @param view
     * Diese Methode wird ausgeführt, wenn eine Checkbox angeklickt wird.
     */
    public void itemClicked(View view) {
        if (checkBox1.isChecked()) {
            preferenceEditor.putInt(boxes, 1);
            preferenceEditor.apply();
        } else if (checkBox2.isChecked()) {
            preferenceEditor.putInt(boxes, 2);
            preferenceEditor.apply();
        } else if (checkBox3.isChecked()) {
            preferenceEditor.putInt(boxes, 3);
            preferenceEditor.apply();
        } else if (checkBox4.isChecked()) {
            preferenceEditor.putInt(boxes, 4);
            preferenceEditor.apply();
        }
    }

    /**
     * Diese Methode restort die Einstellungen,
     * wenn der Benutzer die Settingsview verlässt und später diese wieder aufruft.
     */
    private void loadSettings(){
        if(sharedPreferences != null) {
            radioGroup.check(color);
            settingsSwitch.setChecked(true);
            if(amountBoxes == 1){
                checkBox1.isChecked();
            } else if(amountBoxes == 2){
                checkBox2.isChecked();
            } else if(amountBoxes == 3){
                checkBox3.isChecked();
            } else if(amountBoxes == 4) {
                checkBox4.isChecked();
            }
        } else {
            radioGroup.check(R.id.radioButton1);
            settingsSwitch.setChecked(false);
            checkBox1.isChecked();
            checkBox2.isChecked();
            checkBox3.isChecked();
            checkBox4.isChecked();
        }
    }
}
