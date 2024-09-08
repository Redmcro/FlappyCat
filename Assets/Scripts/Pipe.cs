using UnityEngine;

public class Pipe : MonoBehaviour
{
    public GameObject Cat;
    private Rigidbody2D rb;
    private Cat catScript;
    public LogicManager logic;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        catScript = GameObject.FindGameObjectWithTag("Cat").GetComponent<Cat>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (catScript.catIsAlive == false)
        {
            rb.gravityScale = 1;
            logic.AddScore(100);
        }    
    }
}
