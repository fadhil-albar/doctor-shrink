using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    public int speed = 30;
    public Rigidbody2D sesuatu;
    public obahdrone drone;
    Vector3 posisiawal; /*= new Vector3(19.2f, -4.4f, 0f);*/


    // Start is called before the first frame update
    void Start()
    {
        sesuatu.velocity = new Vector2(-1,-1) * speed;
        posisiawal = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(sesuatu.velocity.x > 0){ // bola bergerak ke kanan
            sesuatu.GetComponent<Transform>().localScale = new Vector3(0.28f, 0.28f, 0.28f);
        }else{
            sesuatu.GetComponent<Transform>().localScale = new Vector3(-0.28f, 0.28f, 0.28f);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.name=="Kanan" || other.collider.name=="Kiri"){
            StartCoroutine(jeda());
        }
    }
    void OnTriggerEnter2D(Collider2D terserah)
    {
        if (terserah.gameObject.name == "triggergan")
        {
            drone.nyawa -= 1;
            transform.position = posisiawal;
        }
    }

    IEnumerator jeda(){
        sesuatu.velocity = Vector2.zero;
        sesuatu.GetComponent<Transform>().position = Vector2.zero;
        yield return new WaitForSeconds(1);
        sesuatu.velocity = new Vector2(-1,-1) * speed;
    }
}
