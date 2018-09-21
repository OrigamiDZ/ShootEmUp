using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalBullet : Bullet {

    [SerializeField]
    private Vector3 angle;

    public override void Update()
    {
        UpdatePosition();
    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == cible.tag)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    public void UpdatePosition()
    {
        transform.position = transform.position + speed * angle / Mathf.Sqrt(angle[0] * angle[0] + angle[1] * angle[1] + angle[2] * angle[2]);
    }
}
