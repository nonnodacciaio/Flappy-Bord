using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public LogicScript Logic;

    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && !Logic.GameOverScreen.activeSelf)
        {
            Logic.AddScore(1);
        }
    }
}
