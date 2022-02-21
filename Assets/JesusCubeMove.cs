using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JesusCubeMove : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    void Start()
    {
        speed = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(horizontal, 0, vertical);
    }
}
