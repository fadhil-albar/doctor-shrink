using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public obahdrone drone;
    public int jumlahvirus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(drone.nyawa == 0) SceneManager.LoadScene("gameover");
        if(jumlahvirus == 0) SceneManager.LoadScene("wingan");
    }
        
}
