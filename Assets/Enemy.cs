using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public gamemanager gm;
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "ball")  // string ball menyesuaikan nama object ball anda
        {
            gm.jumlahvirus -= 1;
            Destroy(gameObject);
        }
    }
}