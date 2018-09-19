using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : Bullet {

    private void Start()
    {
    }

    public override void Update()
    {
        UpdatePosition();
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {

    }

    public void UpdatePosition()
    {
        transform.position = transform.position + speed * Vector3.right; 
    }
}
