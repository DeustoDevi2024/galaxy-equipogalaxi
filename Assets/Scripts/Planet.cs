using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField]
    private int rotationY = 1;
    [SerializeField]
    private GameObject parent;
    [SerializeField]
    private float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        checkRotate();
    }

    private void checkRotate()
    {
        gameObject.transform.rotation *= Quaternion.Euler(0, rotationY * Time.deltaTime, 0);
        if(parent!=null)
        {
        gameObject.transform.RotateAround(parent.transform.position, Vector3.up, speed * Time.deltaTime);
        }
        
    }
}
