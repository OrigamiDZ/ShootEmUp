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

    public float getMaxSpeed()
    {
        return maxSpeed;
    }

    public abstract void decreaseHealth();


}
