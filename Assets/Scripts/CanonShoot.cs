using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;

    private float timer;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance);
        if(distance < 10) 
        {
            timer += Time.deltaTime;

            if (timer > 4)
            {
                timer = 0;
                Shoot();
            }
        }

    }
    void Shoot() 
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
