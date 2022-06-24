using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    public GameObject[] spawnPoints;
    public List<GameObject> ballList;

    public int spawnLimit;

    public float spawnInterval;
    private float timer;
    private void Awake()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoints");
        Debug.Log("Spawn Points Ready");
    }
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (ballList.Count < 5)
        {
            if (timer > spawnInterval)
            {
                spawnBall();
                timer -= spawnInterval;
            }

        }

    }

    private void spawnBall()
    {
        int spawn = Random.Range(0, spawnPoints.Length);
        GameObject generateBall = Instantiate(ball, spawnPoints[spawn].transform.position, Quaternion.identity);
        generateBall.GetComponent<BallController>().BallLaunch(spawn);
        ballList.Add(generateBall);
    }
    public void RemoveBall(GameObject ball)
    {
        ballList.Remove(ball);
        Destroy(ball);
    }
}
