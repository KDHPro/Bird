using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float gravity = 10f;
    public float accel = 10f;
    private float velocity;

    public AudioClip upSound;
    public AudioClip downSound;

    private void Start()
    {
        velocity = 0;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<AudioSource>().PlayOneShot(upSound);
        }

        if (Input.GetButtonUp("Jump"))
        {
            GetComponent<AudioSource>().PlayOneShot(downSound);
        }

        if (Input.GetButton("Jump"))
        {
            velocity += accel * Time.deltaTime;
        }
        else
        {
            velocity -= gravity * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * velocity * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Wall")
        {
            float score = GameManager.Instance.score;

            PlayerPrefs.SetInt("Score", (int)score);
            PlayerPrefs.Save();

            SceneManager.LoadScene("GameOverScene");
        }
    }
}
