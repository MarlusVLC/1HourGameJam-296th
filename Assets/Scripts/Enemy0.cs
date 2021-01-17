using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy0 : MonoBehaviour
{
    public float speedMin = 0.1f;
    public float speedMax = 1f;
    //public float speed = 0.1f;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(speedMin, speedMax);
        //Debug.Log(speed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector2(speed, 0), Space.World);
        die();
    }


    private void die()
    {
        if (transform.position.x >= 10f)
        {
            Destroy(this.transform.gameObject);
        }
    }
}
