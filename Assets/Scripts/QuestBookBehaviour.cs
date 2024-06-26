using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class QuestBookBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject questPage;
    [SerializeField] private Text questTextBox;
    [SerializeField] private GameObject notification;
    [SerializeField] private string[] noQuestsText;
    private bool openBook;

    public void OpenQuestBook()
    {
        openBook = !openBook;
        CreatePage();
        WriteQuests();
    }

    private void CreatePage()
    {
        if (questPage != null && notification != null)
        {
            if (openBook)
            {
                questPage.SetActive(true);
                notification.SetActive(false);
            }
            else
            {
                questPage.SetActive(false);
            }
        }
    }

    private void WriteQuests()
    {
        if (questTextBox != null)
        {
            if (MainManager.mainManager.questNames.Count == 0)
            {
                if (noQuestsText != null)
                {
                    int randomNumber = (Random.Range(0, noQuestsText.Length));
                    questTextBox.text = noQuestsText[randomNumber];
                }
            }
            else
            {
                StringBuilder stringBuilder = new();
                foreach (string quest in MainManager.mainManager.questNames)
                {
                    stringBuilder.AppendLine(quest);
                }
                questTextBox.text = stringBuilder.ToString();
            }

            questTextBox.rectTransform.sizeDelta = new Vector2(questTextBox.rectTransform.sizeDelta.x, 
            questTextBox.preferredHeight);
        }
    }
}

