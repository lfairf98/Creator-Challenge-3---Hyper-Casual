using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    Vector2 moveInput;
    public float speed = 1f;

    void Update()
    {
        moveInput = Vector2.zero;
        if (Input.GetKey(KeyCode.D)) { moveInput.x = 1; }
        if (Input.GetKey(KeyCode.A)) { moveInput.x = -1; }
        transform.position += (Vector3)(moveInput * speed * Time.deltaTime);
    }
}
