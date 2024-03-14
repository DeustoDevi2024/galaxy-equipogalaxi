using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Null : MonoBehaviour
{
    private int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -25 )
        {
            direction = -1 ;
        }
        if (transform.position.x > 25)
        {
            direction = 1;
        }
        transform.position += Vector3.left * direction * Time.deltaTime*10;
    }
}
