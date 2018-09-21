using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour {

    [SerializeField]
    protected float speed;
    [SerializeField]
    protected int damage;
    [SerializeField]
    protected GameObject cible;

    public int getDamage()
    {
        return damage;
    }


    public abstract void Update();

    public abstract void OnTriggerEnter2D(Collider2D collision);

}
