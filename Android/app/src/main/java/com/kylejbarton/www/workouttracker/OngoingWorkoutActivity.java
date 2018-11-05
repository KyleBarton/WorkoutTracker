package com.kylejbarton.www.workouttracker;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.EditText;

import java.util.Calendar;
import java.util.Date;

public class OngoingWorkoutActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ongoing_workout);

        EditText currentDate = findViewById(R.id.currentDate);
        final Calendar cal = Calendar.getInstance();
        cal.add(Calendar.DATE, 0);
//
        currentDate.setText(cal.getTime().toString());

//        Intent intent = getIntent();
    }

    public void startExerciseOne(View view){

        Intent startExerciseIntent = new Intent(this, OngoingExerciseActivity.class);
        startActivity(startExerciseIntent);
    }
}
