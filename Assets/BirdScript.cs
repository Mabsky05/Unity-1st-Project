using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float Flapstrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Bird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * Flapstrength;
            myRigidbody.rotation = 20;
        }
        else if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            myRigidbody.rotation = 0;
        }       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
