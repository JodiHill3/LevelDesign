using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckPassword : MonoBehaviour
{
    public Button button2, button1, button0, button3;
    public TextMeshProUGUI numbersText;

    [SerializeField]
    private GameObject targetGameObject; // Reference to the GameObject to be activated

    private string buttonSequence = ""; // Variable to store the sequence of pressed buttons

    private string targetSequence = "2103"; // Define the target button sequence here

    private bool sequenceCompleted = false; // Flag to indicate if the sequence is completed

    public void ButtonPress(string text)
    {
        switch (text)
        {
            case "del":
                if (buttonSequence.Length > 0)
                {
                    buttonSequence = buttonSequence.Remove(buttonSequence.Length - 1);
                }
                break;

            default:
                OnButtonPress(text);
                break;
        }
    }

    private void FixedUpdate()
    {
        numbersText.text = buttonSequence;
    }

    // Method to handle button presses
    private void OnButtonPress(string digit)
    {
        if (sequenceCompleted)
            return; // Ignore button presses if the sequence is already completed


        buttonSequence += digit; // Add pressed digit to button sequence

        Debug.Log("Button sequence: " + buttonSequence);

        // Check if the current button sequence matches the target sequence
        if (buttonSequence == targetSequence)
        {
            Debug.Log("Correct button sequence entered. Activating GameObject.");
            sequenceCompleted = true; // Mark the sequence as completed
            ActivateGameObject(); // Activate the target GameObject
            DisableButtonComponents(); // Disable Button components to prevent further toggling
        }
    }

    // Method to activate the target GameObject
    private void ActivateGameObject()
    {
        if (targetGameObject != null)
        {
            targetGameObject.SetActive(true); // Set the target GameObject to true
            Debug.Log("GameObject activated: " + targetGameObject.name);
        }
        else
        {
            Debug.LogError("Target GameObject is not assigned!");
        }
    }

    // Method to disable Button components attached to the buttons
    private void DisableButtonComponents()
    {
        button2.interactable = false;
        button1.interactable = false;
        button0.interactable = false;
        button3.interactable = false;
    }
}
