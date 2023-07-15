using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jubiter : MonoBehaviour
{
    public Vector3 pozisyon;
    // Start is called before the first frame update
    void Start()
    {
        pozisyon = new Vector3(0, 0.1f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(pozisyon);
    }
}
