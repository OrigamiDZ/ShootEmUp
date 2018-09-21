using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBullet : Bullet {

    public void Start()
    {
        energy = 0;
        Bullet[] bullets = GetComponentsInChildren<Bullet>();
        for (int i = 0; i <bullets.Length; i++)
        {
            energy = energy + bullets[i].getEnergy();
        }
    }

    public override void Update()
    {
        
    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
        
    }


}
