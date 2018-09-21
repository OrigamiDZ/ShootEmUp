using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BulletType {
    SimpleBullet,
    EnemyBullet,
    DirectionnalBullet
}

public class BulletFactory : MonoBehaviour {

    private List<Bullet> listOfSimpleBullets;
    private List<Bullet> listOfEnemyBullets;
    private List<Bullet> listOfDirectionalBullets;

    [SerializeField]
    private GameObject simpleBullet;
    [SerializeField]
    private GameObject enemyBullet;
    [SerializeField]
    private GameObject multipleBullet;

    public Bullet GetBullet(BulletType bulletType)
    {
        switch (bulletType)
        {
            case BulletType.SimpleBullet:
                if (listOfSimpleBullets.Count <= 0)
                {
                    listOfSimpleBullets.Add(new SimpleBullet());
                }
                return listOfSimpleBullets[0];
            case BulletType.EnemyBullet:
                break;
            case BulletType.DirectionnalBullet:
                break;
            default:
                break;
        }
        return null;
    }

    public void ReleaseBullet(Bullet bullet)
    {
      
    }

}
