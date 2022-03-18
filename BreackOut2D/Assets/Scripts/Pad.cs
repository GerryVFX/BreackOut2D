using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    public float speed = 10f;
    public float limit = 7.7f;

    public void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * speed * Time.deltaTime);

        Vector3 pos = this.transform.position;
        if (pos.x < -limit) pos.x = -limit;
        else if (pos.x > limit) pos.x = limit;
        this.transform.position = pos;


    }

    public void Reset()
    {
        var pos = transform.position;
        pos.x = 0;
        transform.position = pos;
    }
}
