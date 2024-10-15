using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float speed = 2f;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
