using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int resistencia;
    public int powerUps;

    [System.Obsolete]
    public virtual void Start()
    {
        resistencia = 1;
        powerUps = Random.RandomRange(1, 6);

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        var ball=FindObjectOfType<Ball>();
        resistencia -= ball.force;
        if (resistencia <= 0)
        {
            if (powerUps == 2 || powerUps == 4)
            {
                ball.new_ball += 1;
            }
            ball.force += 1;
            gameObject.SetActive(false);
            FindObjectOfType<Grid>().BloquesFinish();
        }
        
    }

    public void Reset()
    {
        gameObject.SetActive(true);
    }
}
