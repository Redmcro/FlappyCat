using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LogicManager : MonoBehaviour
{
    public int score;
    public int endScore = 20;
    public Text scoreText;
    public GameObject Restart;
    public GameObject Cat;
    

    public Animator animator;

    private Text text1;
    private Text text2;
    private Text text3;
    private Button myButton;
    private Button quitButton;
    private Text buttonText;
    private Cat catScript;

    private bool isGameOver = false;

    void Start()
    {
        myButton = Restart.transform.Find("Button").GetComponent<Button>();
        buttonText = myButton.GetComponentInChildren<Text>();
        quitButton = Restart.transform.Find("Quit").GetComponent<Button>();
        text1 = Restart.transform.Find("Text1").GetComponent<Text>();
        text2 = Restart.transform.Find("Text2").GetComponent<Text>();
        text3 = Restart.transform.Find("Text3").GetComponent<Text>();
        catScript = Cat.GetComponent<Cat>();
    }

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        if (score < endScore)
        {
            score += scoreToAdd;
            scoreText.text = score.ToString();
        }
        else
        {
            score += scoreToAdd;
            scoreText.text = $"Winner score: {score}";
            GameOver_3();
        }
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver_1()
    {
        if (isGameOver) return;
        isGameOver = true;
        text1.gameObject.SetActive(true);
        myButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
    }
    public void GameOver_2()
    {
        if (isGameOver) return;
        isGameOver = true;
        text2.gameObject.SetActive(true);
        myButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
    }

    public void PlayAnimation()
    {
        Debug.Log("Trigger Set: playerTrigger");
        animator.SetTrigger("playerTrigger");
    }

    public void GameOver_3()
    {
        if (isGameOver) return;
        isGameOver = true;
        Cat.transform.position = new Vector3(0, 0, 0);
        //Cat.GetComponent<Collider2D>().enabled = false;
        catScript.catIsAlive = false;
        Rigidbody2D rb = Cat.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
        rb.isKinematic = true;
        PlayAnimation();
        text3.gameObject.SetActive(true);
        buttonText.text = "Try Again???";
        myButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
    }

    public void quit()
    {
        Application.Quit();
    }
}