using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float Forward = 2000f;
    public float Left = 1000f;
    public float Right = 1000f;

    void Start()
    {
        
    }

  
    void Update()
    {
        
        GetComponent<Rigidbody>().AddForce(Forward * Time.deltaTime, 0,0);
        
        if(Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, Left * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, -Right * Time.deltaTime );
        }
        
        
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obs"))
        {
            Invoke("Restart", 0.1f);
        }
    }
    void Restart ()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
}


