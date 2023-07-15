using UnityEngine;

public class WingAnimScript : MonoBehaviour
{
    public GameObject Bird;
    public Sprite[] Sprites;

    private SpriteRenderer SpriteRenderer;

    private void Start()
    {
        SpriteRenderer = GameObject.FindGameObjectWithTag("Wing").GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Bird.GetComponent<Rigidbody2D>().velocity.y > 0)
        {
            SpriteRenderer.sprite = Sprites[0];
        }
        else
        {
            SpriteRenderer.sprite = Sprites[1];
        }
    }
}
