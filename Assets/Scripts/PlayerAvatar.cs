using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAvatar : BaseAvatar {

    private GameObject gameController;
    private GameManager game;
    private Animator anima;
    private float nextRegeneration;

    [SerializeField]
    private Slider sliderEnergy;
    [SerializeField]
    private float timeToRecover;
    [SerializeField]
    private int energyToRecover;
    [SerializeField]
    private GameObject[] hearts;

    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        game = gameController.GetComponent<GameManager>();
        anima = GetComponent<Animator>();

        energy = maxEnergy;
        sliderEnergy.maxValue = energy;
    }

    public override void decreaseHealth(int damage)
    {
        health = health - damage;
        anima.SetTrigger("hurt");
        if (health <= 0)
        {
            Die();
            game.GameOver();
        }
        hearts[health].GetComponent<SpriteRenderer>().enabled = false;
    }

    public void increaseEnergy()
    {
        if (Time.time > nextRegeneration && energy < maxEnergy)
        {
            energy = energy + energyToRecover;
            nextRegeneration = Time.time + timeToRecover; ;
        }
    }

    public void Die()
    {
        Destroy(gameObject, 0.2f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary" || other.tag == "Player")
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

    private void Update()
    {
        increaseEnergy();
        sliderEnergy.value = energy;
    }
}
