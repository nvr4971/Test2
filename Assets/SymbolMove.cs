using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolMove : MonoBehaviour
{
    [SerializeField] private float fallSpeed;

    private void Update()
    {
        transform.Translate(Vector2.down  * fallSpeed, Space.World);
    }
}
