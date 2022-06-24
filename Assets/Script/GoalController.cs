using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public PaddleController manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            manager.AddScore();
            other.GetComponent<BallController>().spawnerManager.RemoveBall(other.gameObject);
        }
    }
}
