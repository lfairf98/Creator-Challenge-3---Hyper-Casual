using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int ptsValue;
    Points pts;

    void Start()
    {
        pts = GameObject.Find("PtsManager").GetComponent<Points>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        pts.value += ptsValue;
        Debug.Log(pts.value);
        Destroy(this.gameObject);
    }
}
