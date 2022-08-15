using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public float maxHealth;
    public float currentHealth;
    public float damageBullet;

    public Image lifeBar;
    public ParticleSystem explosion;


    void Start()
    {
        currentHealth = maxHealth;
        lifeBar.fillAmount = 1;

    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("BulletEnemy"))
        {
            explosion.Play();
            currentHealth -= damageBullet;
            lifeBar.fillAmount = currentHealth / maxHealth;
            Destroy(other.gameObject);
            Debug.Log("Hit");
        }
    }
}
