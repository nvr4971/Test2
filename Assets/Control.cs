using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            FireRayCast();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            FireRayCast();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            FireRayCast();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            FireRayCast();
        }
    }

    private void FireRayCast()
    {
        RaycastHit2D hit;

        hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), Vector2.left);

        if (hit.collider != null)
        {
            Debug.Log(hit.collider.gameObject);
        }
    }
}
