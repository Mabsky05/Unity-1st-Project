using UnityEngine;
using UnityEngine.Rendering;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 1;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(Pipe, 
            new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)), 
            transform.rotation);
    }
}
