using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    public float lives = 3.0f;
    private float topBound = 30.0f;
    private float bottomBound = -10.0f;
    private float leadingBound = -30.0f;
    private float trailingBound = 30.0f;
    private ScoreManagement scoreManagement;
    // Start is called before the first frame update
    void Start()
    {
        scoreManagement = GameObject.Find("ScoreManagement").GetComponent<ScoreManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
            scoreManagement.LooseALife();
        }else if(transform.position.x > trailingBound)
        {
            Destroy(gameObject);
            scoreManagement.LooseALife();
        }
        else if(transform.transform.position.x < leadingBound)
        {
            Destroy(gameObject);
            scoreManagement.LooseALife();
        }
    }
}
