using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = 3f;
    public float size = 19.2f;

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < -size)
        {
            transform.Translate(new Vector3(size * 2, 0, 0));
        }
    }
}
