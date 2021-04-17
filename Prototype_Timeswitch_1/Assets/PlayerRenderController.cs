using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRenderController : MonoBehaviour
{
    public SpriteRenderer Player_Modern;
    public SpriteRenderer Player_Old;
    public ParticleSystem Transform_Particles;
    // Start is called before the first frame update
    void Start()
    {
        Player_Modern.enabled = true;
        Player_Old.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("q"))
        {
            Transform_Particles.Play();
        }
        if (Input.GetKeyUp("q"))
        {
            StartCoroutine(ChangeCharacterAge());
        }
    }
    IEnumerator ChangeCharacterAge()
    {
        if (Player_Modern.enabled)
        {
            Player_Modern.enabled = false;
            Player_Old.enabled = true;
        }
        else
        {
            Player_Old.enabled = false;
            Player_Modern.enabled = true;
        }
        Transform_Particles.Play();
        yield return new WaitForSeconds(5);
    }
}
