using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InputManager : MonoBehaviour {

    private Vector2 speed;
    private Engine moteur;
    private BulletGun gun;

    
    private int currentGun;


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

        if (Input.GetKey("tab") && Time.time > gun.getNextFire())
        {
            currentGun++;
            if (currentGun >= gun.getNbGun())
            {
                currentGun = 0;
            }
        }

        if (Input.GetKey("space") && Time.time > gun.getNextFire())
        {
            if (currentGun == 0)
            {
                gun.Shot();
            }
            if (currentGun == 1)
            {
                gun.ShotMultiple();
            }
        }
    }
}
