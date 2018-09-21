using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGun : MonoBehaviour {

    [SerializeField]
    private GameObject shot;
    [SerializeField]
    private GameObject shotMultiple;

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
        Instantiate(shotMultiple, shotSpawn.position, shotSpawn.rotation);
        Bullet bull = shotMultiple.GetComponent<Bullet>();
        if (avatar != null)
        {
            avatar.setEnergy(avatar.getEnergy() - bull.getEnergy());
        }

    }
}
