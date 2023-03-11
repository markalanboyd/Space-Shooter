using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-7.0f, 7.0f), 7, 0);
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y <= -7.0f)
        {
            float randomX = Random.Range(-7.0f, 7.0f);
            transform.position = new Vector3(randomX, 7, 0);
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Hit" + other.transform.name);
    }
}
