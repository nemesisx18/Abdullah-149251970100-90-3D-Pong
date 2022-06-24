using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rig;
    public BallSpawner spawnerManager;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        spawnerManager = FindObjectOfType<BallSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BallLaunch(int indexPosition)
    {
        float randomZ = Random.Range((float)0.5, 2);
        float randomX = Random.Range((float)0.5, 2);
        float randomMinZ = Random.Range((float)-0.5, -2);
        float randomMinX = Random.Range((float)-0.5, -2);
        switch (indexPosition)
        {
            case 0:
                rig.velocity = new Vector3(randomX, 0, randomZ);
                break;
            case 1:
                rig.velocity = new Vector3(randomMinX, 0, randomZ);
                break;
            case 2:
                rig.velocity = new Vector3(randomMinX, 0, randomMinZ);
                break;
            case 3:
                rig.velocity = new Vector3(randomX, 0, randomMinZ);
                break;
        }
    }
}
