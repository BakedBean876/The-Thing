using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{

    public Rigidbody2D rigid;

    public float up;
    public float right;
    public float left;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigid.velocity += Vector2.up * up;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * left * Time.deltaTime);
        }
    }
}
