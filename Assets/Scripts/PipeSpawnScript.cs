using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject Pipe;
    public BirdScript BirdScript;
    public float SpawnRate = 2;
    public float HeightOffset = 10;

    private float Timer = 0;

    void Start()
    {
        BirdScript = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
        SpawnPipe();
    }

    void Update()
    {
        if (Timer < SpawnRate)
        {
            Timer += Time.deltaTime;
        }
        else if (BirdScript.BirdIsAlive)
        {
            SpawnPipe();
            Timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - HeightOffset;
        float highestPoint = transform.position.y + HeightOffset;

        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
