using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGun : MonoBehaviour {

    [SerializeField]
    private GameObject shot;
    [SerializeField]
    private Transform shotSpawn;
    [SerializeField]
    private float fireRate;

    private float nextFire;


    public GameObject getShot()
    {
        return shot;
    }
    public Transform getShotspawn()
    {
        return shotSpawn;
    }
    public float getFireRate()
    {
        return fireRate;
    }
    public float getNextFire()
    {
        return nextFire;
    }

    public void Shot()
    {
        nextFire = Time.time + fireRate;
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    }
}
