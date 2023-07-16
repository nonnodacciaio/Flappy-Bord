using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D RigidBody;
    public float FlapStrength = 20f;
    public LogicScript Logic;
    public bool BirdIsAlive = true;

    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && BirdIsAlive)
        {
            Jump();
        }

        if (Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
        {
            Jump();
        }

        if ((gameObject.transform.position.y > 17 || gameObject.transform.position.y < -13) && BirdIsAlive)
        {
            KillBird();
        }
    }

    public void Jump()
    {
        RigidBody.velocity = Vector2.up * FlapStrength;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (BirdIsAlive)
        {
            KillBird();
        }
    }

    private void KillBird()
    {
        Logic.GameOver();
        BirdIsAlive = false;
    }
}
