using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBasicEngine : MonoBehaviour {

    private BulletGun gun;
    private Engine moteur;

    void Start()
    {
        gun = GetComponent<BulletGun>();
        moteur = GetComponent<Engine>();


        InvokeRepeating("Fire", gun.getNextFire(), gun.getFireRate());
    }

    void Fire()
    {
        Instantiate(gun.getShot(), gun.getShotspawn().position, gun.getShotspawn().rotation);
    }


}
