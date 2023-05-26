using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;

    [SerializeField]
    private int Max_Height = 5;

    [SerializeField]
    private int Min_Height = -5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveUpDown();
    }

    private void MoveUpDown()
    {
        if (transform.position.y > Max_Height)
        {
            speed = -Mathf.Abs(speed);
        }
        else if (transform.position.y < Min_Height)
        {
            speed = Mathf.Abs(speed);
        }
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
    }
}