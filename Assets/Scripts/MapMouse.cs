using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMouse : MonoBehaviour
{

    private Vector3 mousePosi;
    private Vector3 mousePosiInitial;
    private Vector3 InitialPosiImg;
    public float scaleFactor;
    public float shakespeed;
    public float shakeAmplitude;
    // Use this for initialization
    void Start()
    {
        mousePosiInitial = Input.mousePosition;
        InitialPosiImg = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosi = Input.mousePosition;
        gameObject.transform.position = InitialPosiImg + mousePosi * scaleFactor + Mathf.Sin(Time.time * shakespeed) * shakeAmplitude * Vector3.up;
    }
}
