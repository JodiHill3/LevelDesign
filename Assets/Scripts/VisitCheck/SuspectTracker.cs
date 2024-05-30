using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuspectTracker : MonoBehaviour
{
    public bool visitedMelville;
    public bool visitedDakota;
    public bool visitedGuinevere;
    public bool visitedTodd;
    public bool visitedBeau;
    public bool visitedLyssa;
    public bool visitedRaz;
    public bool visitedCoy;
    public bool visitedIlma;

    public bool visitedAll;

    private static SuspectTracker _instance;

    public static SuspectTracker Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SetVisit(string person)
    {
        person = person.ToLower();

        switch (person)
        {
            case "melville":
                visitedMelville = true;
                break;
            case "dakota":
                visitedDakota = true;
                break;
            case "guinevere":
                visitedGuinevere = true;
                break;
            case "beau":
                visitedBeau = true;
                break;
            case "todd":
                visitedTodd = true;
                break;
            case "lyssa":
                visitedLyssa = true;
                break;
            case "ilma":
                visitedIlma = true;
                break;
            case "raz":
                visitedRaz = true;
                break;
            case "coy":
                visitedCoy = true;
                break;
        }
    }

    private void FixedUpdate()
    {
        if (!visitedAll)
        {
            if (visitedMelville && visitedBeau && visitedDakota && visitedCoy && visitedGuinevere && 
                visitedLyssa && visitedRaz && visitedTodd && visitedIlma)
            {
                visitedAll = true;
            }
        }
    }
}
