using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : Bullet {
    public override void Update()
    {
        UpdatePosition();
    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == cible.tag)
        {
            Destroy(gameObject);
        }
    }

    public void UpdatePosition()
    {
        transform.position = transform.position + speed * Vector3.right; 
    }
}
