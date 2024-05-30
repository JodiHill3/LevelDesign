using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visitor : MonoBehaviour
{
    public GameObject whodunnit;

    void FixedUpdate()
    {
        if (SuspectTracker.Instance.visitedAll)
        {
            whodunnit.SetActive(true);
        }
    }
}
