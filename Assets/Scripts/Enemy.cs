using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public int speed;
    public int distanceToPlayer;

    public GameObject bullet;
    public GameObject[] posBullet;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("Attack", 2, Randomice());

    }

    void Update()
    {
        transform.LookAt(player.transform);

        float distance = Vector3.Distance(transform.position, player.transform.position);
        if(distance > distanceToPlayer)
        {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        Randomice();
    }

    void Attack()
    {
        for(int i = 0; i< 2; i++)
        {
            Instantiate(bullet, posBullet[i].transform.position, posBullet[i].transform.rotation);
        }

        
    }

    float Randomice()
    {
        float result;
        result = Random.Range(1f,5f);

        return result;
    }
}
