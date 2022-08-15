using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int turnspeed;
    public int speed;
    Vector3 rotation;
    public bool invertY;

    float yMouse;

    float delta;

    public GameObject bulletPrefab;
    public Transform posBullet;
    public Transform posBullet2;
    public Transform posBullet3;
    public Transform posBullet4;


    AudioSource audioSource;


    void Start()
    {
        delta = Time.deltaTime;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Rotation();
        Attack();

    }

    void Movement()
    {
 
        float v = Input.GetAxis("Vertical");
      
        Vector3 direction = new Vector3(0, 0, v);
        transform.Translate(direction.normalized * speed * delta);

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed*2;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed/2;
        }


        
    }

    void Rotation()
    {
        float xMouse = Input.GetAxis("Mouse X");
        float h = Input.GetAxis("Horizontal");
        
        yMouse = Input.GetAxis("Mouse Y");

        // transform.Rotate(Vector3.up.normalized * turnspeed * yMouse * Time.deltaTime);
        // transform.Rotate(Vector3.right.normalized * turnspeed * xMouse * Time.deltaTime);

        if(invertY == true)
        {
            rotation = new Vector3(-yMouse, xMouse, -h);
        }
        else
        {
            rotation = new Vector3(yMouse, xMouse, -h);
        }

        transform.Rotate(rotation.normalized * turnspeed * delta);

    }

    void Attack()
    {
        if(Input.GetMouseButtonDown(0))
        {
            audioSource.Play();
            Instantiate(bulletPrefab, posBullet.position, posBullet.rotation);
            Instantiate(bulletPrefab, posBullet2.position, posBullet2.rotation);
            Instantiate(bulletPrefab, posBullet3.position, posBullet3.rotation);
            Instantiate(bulletPrefab, posBullet4.position, posBullet4.rotation);
        }
    }


}
