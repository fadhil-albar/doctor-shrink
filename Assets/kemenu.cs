using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kemenu : MonoBehaviour
{
    public AudioSource audioSource;
    void Start()
    {
        Destroy(audioSource);
    }
    public void menu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
