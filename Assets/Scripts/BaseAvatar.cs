using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAvatar : MonoBehaviour {

    [SerializeField]
    protected int health;

    [SerializeField]
    protected int energy;

    [SerializeField]
    protected float maxSpeed;

    [SerializeField]
    protected int scoreValue;

    [SerializeField]
    protected int damage;

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
