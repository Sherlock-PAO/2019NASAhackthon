using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class BulletGenerator : MonoBehaviour
{


    public Rigidbody Bullet;
    public GameObject MyShuttle;
    public float fireRate;
    private static float nextFire = 0.0f;
    public float v;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Rigidbody MyBullet = Instantiate(Bullet, MyShuttle.transform.position, MyShuttle.transform.rotation);
            MyBullet.velocity = MyShuttle.transform.TransformDirection(v, 0, 0) * v;
            Destroy(MyBullet.gameObject, 1.5f);
        }


    }



}