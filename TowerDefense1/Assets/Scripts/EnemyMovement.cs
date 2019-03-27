using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyMovement : MonoBehaviour
{
    public float EnemySpeed;
    public Rigidbody2D rBody;
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rBody.velocity = transform.up * EnemySpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("RightTurn"))
        {
            transform.eulerAngles = new Vector3(0,0,-90);
        }
        if (collision.CompareTag("LeftTurn"))
        {
            transform.eulerAngles = new Vector3(0,0,90);
        }
        if (collision.CompareTag("DownTurn"))
        {
            transform.eulerAngles = new Vector3(0, 0, -180);
        }
        if (collision.CompareTag("UpTurn"))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
