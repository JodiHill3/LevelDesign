using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubsScript : MonoBehaviour
{
    public GameObject textBox;
    public bool subDec = true;
    public GameObject buttonText;

    void Update()
    {
        
    }
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(1);
        textBox.GetComponent<TextMeshProUGUI>().text = "Hey";
        yield return new WaitForSeconds(4);
        textBox.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<TextMeshProUGUI>().text = "Bye";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<TextMeshProUGUI>().text = "Okay";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<TextMeshProUGUI>().text = "";
    }

    public void SwitchSubs()
    {
        if (subDec == false)
        {
            textBox.SetActive(true);
            subDec = true;
            return;
        }
        if (subDec == true)
        {
            textBox.SetActive(false);
            subDec = false;
            return;
        }
    }
}
