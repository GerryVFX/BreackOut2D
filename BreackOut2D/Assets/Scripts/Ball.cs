using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float pad_OffsetY = 0.4f;
    public bool is_Go;
    public float speed_Ball = 7f;
    public int force = 1;
    public int n_ball = 1;
    public int new_ball = 1;
    [SerializeField] Rigidbody2D rigiBall;

    private void Awake()
    {
        rigiBall = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (new_ball >= n_ball)
        {
            Instantiate(this.gameObject);
            GoBall();
            n_ball = new_ball + 1;
        }
        if (force >=3 )
        {
            force = 3;
        }
        if (!is_Go) 
        {
            PositionBall();
            if (Input.GetKeyDown(KeyCode.Joystick1Button0)) GoBall();

        }
        
    }

    void PositionBall()
    {
        var pad = FindObjectOfType<Pad>();
        var pad_Pos = pad.transform.position;
        transform.position = pad_Pos + new Vector3(0, pad_OffsetY, 0);
    }

    void GoBall()
    {
        var direction = new Vector2(1, 1);
        rigiBall.velocity = direction.normalized * speed_Ball;
        is_Go = true;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var contact = collision.GetContact(0);
        rigiBall.velocity = Vector2.Reflect(rigiBall.velocity, contact.normal);
    }

    public void Reset()
    {
        force = 1;
        rigiBall.velocity = new Vector2(0, 0);
        PositionBall();
        is_Go = false;
    }
}
