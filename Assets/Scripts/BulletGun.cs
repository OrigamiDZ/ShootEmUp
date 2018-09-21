using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGun : MonoBehaviour {

    [SerializeField]
    private GameObject shot;
    [SerializeField]
    private GameObject shot45;
    [SerializeField]
    private GameObject shot23;
    [SerializeField]
    private GameObject shot68;
    [SerializeField]
    private GameObject shot45m;
    [SerializeField]
    private GameObject shot23m;
    [SerializeField]
    private GameObject shot68m;
    [SerializeField]
    private Transform shotSpawn;
    [SerializeField]
    private float fireRate;
    [SerializeField]
    private int nbGun;

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
    public int getNbGun()
    {
        return nbGun;
    }

    public void Shot()
    {
        nextFire = Time.time + fireRate;
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    }

    public void ShotMultiple()
    {
        nextFire = Time.time + fireRate;

        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

        Instantiate(shot23, shotSpawn.position, shotSpawn.rotation);
        Instantiate(shot45, shotSpawn.position, shotSpawn.rotation);
        Instantiate(shot68, shotSpawn.position, shotSpawn.rotation);

        Instantiate(shot23m, shotSpawn.position, shotSpawn.rotation);
        Instantiate(shot45m, shotSpawn.position, shotSpawn.rotation);
        Instantiate(shot68m, shotSpawn.position, shotSpawn.rotation);

    }
}
