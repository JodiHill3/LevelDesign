using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitChecker : MonoBehaviour
{
    public string character;

    void Start()
    {
        SuspectTracker.Instance.SetVisit(character);    
    }
}
