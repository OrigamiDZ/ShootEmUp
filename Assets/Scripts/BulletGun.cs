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
    private PlayerAvatar avatar;

    private void Start()
    {
        avatar = GetComponent<PlayerAvatar>();
    }

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
        Bullet bull = shot.GetComponent<Bullet>();
        if (avatar != null)
        {
            avatar.setEnergy(avatar.getEnergy() - bull.getEnergy());
        }

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

        Bullet bull = shot.GetComponent<Bullet>();
        Bullet bull2 = shot23.GetComponent<Bullet>();
        Bullet bull3 = shot23m.GetComponent<Bullet>();
        Bullet bull4 = shot45.GetComponent<Bullet>();
        Bullet bull5 = shot45m.GetComponent<Bullet>();
        Bullet bull6 = shot68.GetComponent<Bullet>();
        Bullet bull7 = shot68m.GetComponent<Bullet>();
        if (avatar != null)
        {
            avatar.setEnergy(avatar.getEnergy() - 
                bull.getEnergy() - 
                bull2.getEnergy() - 
                bull3.getEnergy() - 
                bull4.getEnergy() - 
                bull5.getEnergy() -
                bull6.getEnergy() -
                bull7.getEnergy());
        }

    }
}
