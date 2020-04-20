using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oba : MonoBehaviour
{
    public int speed = 30;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0) * speed;
        }
    }
}
