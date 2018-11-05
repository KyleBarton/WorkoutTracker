package com.kylejbarton.www.workouttracker.domain;

public class Set {
    private int weight;
    private int reps;
    public Set(int weight, int reps){
        this.weight = weight;
        this.reps = reps;
    }

    public int getWeight(){
        return this.weight;
    }
    public int getReps(){
        return this.reps;
    }
}
