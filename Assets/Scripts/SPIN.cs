using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPIN : MonoBehaviour
{
    float _angle = 0f;
    public float rotationSpeed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _angle += rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.AngleAxis(_angle, Vector3.up);
    }
}
