using UnityEngine;

public class Cat : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public Transform myTransform;
    public float flapStrength;
    public LogicManager logic;
    public bool catIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && catIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if (myTransform.position.y < -45 || myTransform.position.x < -75)
        {
            logic.GameOver_2();
            catIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver_1();
        catIsAlive = false;
    }

}
