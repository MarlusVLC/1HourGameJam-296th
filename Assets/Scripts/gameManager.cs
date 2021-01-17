using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject enemy;
    public float genTime = 3f;
    public float minTime = 1f;
    public float maxTime = 4f;
    public float minHeight = -4.2f;
    public float maxHeight = 2.2f;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= genTime)
        {
            float newHeight = Random.Range(minHeight, maxHeight);
            GameObject.Instantiate(enemy, new Vector2(-14, newHeight), Quaternion.identity);
            timer = 0;
            genTime = Random.Range(minTime, maxTime);
        }
    }
}
