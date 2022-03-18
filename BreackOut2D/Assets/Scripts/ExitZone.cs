using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitZone : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<Pad>().Reset();
        FindObjectOfType<Ball>().Reset();
    }
}
