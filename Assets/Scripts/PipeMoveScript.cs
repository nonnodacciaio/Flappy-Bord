using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float MoveSpeed = 5;
    public float DeadZone = -45;
    public BirdScript BirdScript;

    void Start()
    {
        BirdScript = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;

        if (!BirdScript.BirdIsAlive)
        {
            MoveSpeed = 0;
        }

        if (transform.position.x < DeadZone)
        {
            Destroy(gameObject);
        }
    }
}
