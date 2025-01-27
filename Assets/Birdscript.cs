using Unity.VisualScripting;
using UnityEngine;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapstrength;
    public LogicScript logic;
    private bool Alive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        gameObject.name = "birdington";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Alive)
        {
            myRigidBody.linearVelocity = Vector2.up * flapstrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        Alive = false;
    }
}
