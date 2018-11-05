package com.kylejbarton.www.workouttracker;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class EntryActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_entry);
    }

    public void startWorkout(View view){
        Intent startWorkoutIntent = new Intent(this, OngoingWorkoutActivity.class);
        startActivity(startWorkoutIntent);
    }
}
