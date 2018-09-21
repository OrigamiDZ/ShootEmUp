using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAvatar : MonoBehaviour {

    [SerializeField]
    protected int health;

    [SerializeField]
    protected int maxEnergy;

    [SerializeField]
    protected float maxSpeed;

    [SerializeField]
    protected int scoreValue;

    [SerializeField]
    protected int damage;

    protected int energy;

    public int getEnergy()
    {
        return energy;
    }
    public void setEnergy(int newEnergy)
    {
        energy = newEnergy;
    }
    public float getMaxSpeed()
    {
        return maxSpeed;
    }

    public int getDamage()
    {
        return damage;
    }

    public int getScoreValue()
    {
        return scoreValue;
    }

    public abstract void decreaseHealth(int damage);


}
