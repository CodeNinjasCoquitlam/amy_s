using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAndRotatingObjects : MonoBehaviour
{
    [Header("Default Movement Speed")]
    //default moving speed
    public float moveSpeed = 20f;

    [Header("Default Rotation Speed")]
    //default rotating speed
    public float rotateSpeed = 70f;

    // Start is called before the first frame update
    void Start()
    {
        //object moving on the y axis based on move speed
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        //rotate  on the x axis based on rotae speed
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
