using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    new private Rigidbody2D rigidbody2D;
    private int rotationMeasurement;
    public SpriteRenderer rendererPlayerModern;
    public SpriteRenderer rendererPlayerOld;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetAxis("Horizontal") != 0)
        {*/
            /*rigidbody2D.AddForce(new Vector2 (10*Input.GetAxis("Horizontal"), 0));*/
        
        if (Input.GetAxis("Horizontal") == 1){
            rendererPlayerModern.flipX = false;
            rendererPlayerOld.flipX = false;
        }
        if (Input.GetAxis("Horizontal") == -1)
        {
            //transform.localRotation = Quaternion.Euler(transform.rotation.x, 180, 0);
            rendererPlayerModern.flipX = true;
            rendererPlayerOld.flipX = true;
        }
        /*}
        /*if (Input.GetAxis("Vertical") != 0)
        {
            rigidbody2D.AddForce(new Vector2 (0, 5 * Input.GetAxis("Vertical")));
        }*/
        rigidbody2D.velocity = new Vector3(20 * Input.GetAxis("Horizontal"), rigidbody2D.velocity.y, 0);
        if (Input.GetKey("space"))
        {
            rigidbody2D.AddForce(new Vector2(0, 20));
        }
        if (Input.GetKey("r"))
        {
            rigidbody2D.AddForce(new Vector2(0, 20));
            StartCoroutine(sleepSubRoutine());
            
        }
        if (Input.GetKey("e"))
        {
            rigidbody2D.velocity = new Vector3(0, -50, 0);
        }
    }
    private IEnumerator sleepSubRoutine()
    {
        yield return new WaitForSeconds(0.2f);
        transform.Rotate(Vector3.forward, 360 * Time.deltaTime);
    }

}
