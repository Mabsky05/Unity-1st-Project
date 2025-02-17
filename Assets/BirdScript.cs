using UnityEngine;
using UnityEngine.UIElements;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float Flapstrength; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Bird";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.linearVelocity = Vector2.up * Flapstrength;
            myRigidbody.rotation = 20;
        }
        else if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            myRigidbody.rotation = 0;
        }
        
    }
}
