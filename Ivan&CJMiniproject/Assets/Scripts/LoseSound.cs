using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseSound : MonoBehaviour
{
    public AudioSource Lose;
    // Start is called before the first frame update
    void Start()
    {
        Lose.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
