using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAvatar : BaseAvatar {

    private GameObject gameController;
    private GameManager game;
    private Animator anima;

    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        game = gameController.GetComponent<GameManager>();
        anima = GetComponent<Animator>();
    }

    public override void decreaseHealth(int damage)
    {
        health = health - damage;
        anima.SetTrigger("EnemyHurt");
        if (health <= 0)
        {
            Die();
            game.AddScore(scoreValue);
        }
    }

    public void Die()
    {
        Destroy(gameObject, 0.2f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary" || other.tag == "Enemy")
        {
            return;
        }

        GameObject autre = other.gameObject;

        int damage = 0;

        if (autre.GetComponent<BaseAvatar>() != null)
        {
            damage = (autre.GetComponent<BaseAvatar>()).getDamage();
        }
        else if (autre.GetComponent<Bullet>() != null)
        {
            damage = (autre.GetComponent<Bullet>()).getDamage();
        }

        decreaseHealth(damage);
    }
}
