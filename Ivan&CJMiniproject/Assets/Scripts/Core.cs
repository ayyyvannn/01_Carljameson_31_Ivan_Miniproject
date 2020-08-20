using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Core : MonoBehaviour
{
    public int coreLives = 100;
    public Text coreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            coreLives -= 10;
            coreText.text = "Health: " + coreLives;
        }
    }
}
