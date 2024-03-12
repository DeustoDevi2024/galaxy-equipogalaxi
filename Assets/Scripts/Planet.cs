using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    private GameObject[] gameObjectsD;
    private GameObject[] gameObjectsI;
    private int rotationX = 0;
    public int rotationY = 1;
    private int rotationZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObjectsD = GameObject.FindGameObjectsWithTag("Planeta1");
        gameObjectsI = GameObject.FindGameObjectsWithTag("Planeta2");
    }

    // Update is called once per frame
    void Update()
    {
        checkRotate();
    }

    private void checkRotate()
    {
        for (GameObject planetaD : gameObjectsD)
        {
                planetaD.transform.rotation *= Quaternion.Euler(rotationX, rotationY, rotationZ);
        }
        for (GameObject planetaI : gameObjectsI)
        {
                planetaI.transform.rotation *= Quaternion.Euler(rotationX, (-1) * rotationY, rotationZ);
        }
        
    }
}
