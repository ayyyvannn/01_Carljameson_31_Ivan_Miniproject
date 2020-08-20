using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform bulletpoint;
    public GameObject bulletpre;

    public float bulletForce = 20f;

    public float moveSpeed = 600f;
    float movement = 0f;


   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        movement = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        
                  
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletpre, bulletpoint.position, transform.rotation);
 
    }
}
