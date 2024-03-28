using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput; 
    public float speed = 10; 
    public float xRange = 25; 
    public float zRange = 8;
    public GameObject projectilePrefab;
    public float vInput; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hInput * Time.deltaTime * speed);

        vInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * vInput * Time.deltaTime * speed);

       // invisible barrier function/////
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z >zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
     // wine launcher variable///
        if (Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.Space))
        {
            // this function will launch the projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);  
        }
    }
}
