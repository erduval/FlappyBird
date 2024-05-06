using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider2D))]
public class PointBehaviour : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * 1f * Time.deltaTime;

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Pipe" && collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Point");
            GameManager.Instance.AddScore(1);
        }
    }
}
