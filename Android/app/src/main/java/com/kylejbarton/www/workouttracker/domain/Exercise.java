package com.kylejbarton.www.workouttracker.domain;

import java.util.LinkedList;
import java.util.List;

public class Exercise {
    private ExerciseType type;
    public Exercise(ExerciseType type){
       this.type = type;
    }
    private List<Set> sets = new LinkedList<Set>();

    public List<Set> getSets(){
        return sets;
    }
}

