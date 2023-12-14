using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{  
    public float speed = 20;
    
    public float horizontalInput;
    public float verticalInput;
    public ParticleSystem explosionParticle;
    public ParticleSystem popcornParticle;
    private AudioSource playerAudio;
    public  AudioClip BombSound;
    public AudioClip FireworkSound;
    

  

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
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


    void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.CompareTag("Bomb"))
      {
          explosionParticle.Play();
          playerAudio.PlayOneShot(BombSound, 1.0f);
      }
      else if (other.gameObject.CompareTag("Popcorn"))
      {
        popcornParticle.Play();
        playerAudio.PlayOneShot(FireworkSound, 1.0f);
      }
      
    }


    




}
