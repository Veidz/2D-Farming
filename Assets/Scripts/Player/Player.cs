using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    private new Rigidbody2D rigidbody2D;
    private Vector2 direction;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        direction = new Vector2(horizontal, vertical);
    }

    private void FixedUpdate()
    {
        rigidbody2D.MovePosition(rigidbody2D.position + speed * Time.fixedDeltaTime * direction);
    }
}
