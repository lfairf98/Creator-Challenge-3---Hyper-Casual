using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float bounce = 0;

    public void OnCollisionEnter(Collision collision)
    {
        // Get the collision point in local space
        Vector3 localCollisionPoint = transform.InverseTransformPoint(collision.contacts[0].point);

        // Get the collision normal in local space
        Vector3 localCollisionNormal = transform.InverseTransformDirection(collision.contacts[0].normal);

        // Calculate the collision angle in degrees
        float angle = Mathf.Atan2(localCollisionNormal.x, localCollisionNormal.y) * Mathf.Rad2Deg;

        Vector3 forceDirection = Quaternion.AngleAxis(-angle, Vector3.forward) * Vector3.up;
        GetComponent<Rigidbody>().AddForce(forceDirection * bounce, ForceMode.Impulse);

        Debug.Log("Collision angle: " + angle);
    }
}