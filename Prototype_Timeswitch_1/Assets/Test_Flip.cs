using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Flip : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("t"))
        {
            spriteRenderer.flipX = true;
        }
    }
}
