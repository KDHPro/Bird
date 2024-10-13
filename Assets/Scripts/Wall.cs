using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private float speed;

    private void Awake()
    {
        speed = Random.Range(1.5f, 2f);
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
