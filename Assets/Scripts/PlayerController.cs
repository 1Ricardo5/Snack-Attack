using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{  
    public float speed = 20;
    
    public float horizontalInput;
    public float verticalInput; 

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        if (transform.position.x < -9){
        transform.position = new Vector3(-9, transform.position.y, transform.position.z);
      }
      
      if (transform.position.x > 9)
      {
        transform.position = new Vector3(9, transform.position.y, transform.position.z);
      }
        if (transform.position.z < -6){
        transform.position = new Vector3(transform.position.x, transform.position.y, -6);
      }
      
      if (transform.position.z > 6)
      {
        transform.position = new Vector3(transform.position.x, transform.position.y, 6);
      }

    }
}
