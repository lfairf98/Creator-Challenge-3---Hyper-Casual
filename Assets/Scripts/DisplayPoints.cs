using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayPoints : MonoBehaviour
{
    Points pts;
    public TextMeshProUGUI pointUI;

    void Start()
    {
        pts = GameObject.Find("PtsManager").GetComponent<Points>();
    }
    private void Update()
    {
        pointUI.text = string.Format("{0:0}", pts.value);
    }
}
