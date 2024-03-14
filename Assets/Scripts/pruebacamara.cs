using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebacamara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Rotation();
    }

    private void Rotation()
    {
        float rotateDirX = 0f;
        float rotateDirY = 0f;
        if (Input.GetKey(KeyCode.LeftArrow)) rotateDirX = 1f;
        if (Input.GetKey(KeyCode.RightArrow)) rotateDirX = -1f;
        if (Input.GetKey(KeyCode.UpArrow)) rotateDirY = 1f;
        if (Input.GetKey(KeyCode.DownArrow)) rotateDirY = -1f;

        float rotateSpeed = 300f;

        transform.eulerAngles += new Vector3(rotateDirY * rotateSpeed * Time.deltaTime, rotateDirX * rotateSpeed * Time.deltaTime,0);
    }

    private void Movement()
    {
        Vector3 inputDir = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W)) inputDir.z = 1f;
        if (Input.GetKey(KeyCode.S)) inputDir.z = -1f;
        if (Input.GetKey(KeyCode.A)) inputDir.x = -1f;
        if (Input.GetKey(KeyCode.D)) inputDir.x = 1f;
        if (Input.GetKey(KeyCode.Q)) inputDir.y = 1f;
        if (Input.GetKey(KeyCode.E)) inputDir.y = -1f;

        Vector3 moveDir = transform.forward * inputDir.z + transform.right * inputDir.x + transform.up * inputDir.y;

        float movespeed = 50f;
        transform.position += moveDir * movespeed * Time.deltaTime;
    }
}
