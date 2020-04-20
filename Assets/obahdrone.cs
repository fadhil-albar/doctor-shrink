using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obahdrone : MonoBehaviour
{
    public int nyawa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(horizontalMove, 0) * 50 * Time.deltaTime);
    }
}
