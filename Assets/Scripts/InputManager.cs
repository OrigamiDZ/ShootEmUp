using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InputManager : MonoBehaviour {

    private Vector2 speed;
    private Engine moteur;
    private BulletGun gun;


    public Vector2 getSpeed()
    {
        return speed;
    }

    private void Start()
    {
        moteur = GetComponent<Engine>();
        gun = GetComponent<BulletGun>();
    }

    void Update () {
        speed = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moteur.Move(speed);

        if (Input.GetKey("space") && Time.time > gun.getNextFire())
        {
            gun.Shot();
        }
    }
}
