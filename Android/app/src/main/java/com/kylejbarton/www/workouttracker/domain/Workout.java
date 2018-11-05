package com.kylejbarton.www.workouttracker.domain;

import java.util.LinkedList;
import java.util.List;

public class Workout {
    private List<Exercise> exercises = new LinkedList<Exercise>();

    public List<Exercise> getExercises(){
        return exercises;
    }
}

