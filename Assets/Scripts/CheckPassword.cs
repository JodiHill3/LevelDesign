using UnityEngine;
using UnityEngine.UI;

public class CheckPassword : MonoBehaviour
{
    [SerializeField]
    private Button button7, button2, button1A, button9, button1B, button4; // References to the buttons

    [SerializeField]
    private GameObject targetGameObject; // Reference to the GameObject to be activated

    private string buttonSequence = ""; // Variable to store the sequence of pressed buttons

    private string targetSequence = "721914"; // Define the target button sequence here

    private bool sequenceCompleted = false; // Flag to indicate if the sequence is completed

    private string lastPressedButton = ""; // Variable to store the last pressed button

    void Start()
    {
        // Subscribe to button click events
        button7.onClick.AddListener(() => OnButtonPress("7"));
        button2.onClick.AddListener(() => OnButtonPress("2"));
        button1A.onClick.AddListener(() => OnButtonPress("1A"));
        button9.onClick.AddListener(() => OnButtonPress("9"));
        button1B.onClick.AddListener(() => OnButtonPress("1B"));
        button4.onClick.AddListener(() => OnButtonPress("4"));
    }

    // Method to handle button presses
    private void OnButtonPress(string digit)
    {
        if (sequenceCompleted)
            return; // Ignore button presses if the sequence is already completed

        // If the pressed button is "1A" or "1B", treat it as "1"
        if (digit == "1A" || digit == "1B")
            digit = "1";

        // Check if the last pressed button is the same as the current one
        if (lastPressedButton == digit)
            return; // Ignore the current button press

        buttonSequence += digit; // Add pressed digit to button sequence
        lastPressedButton = digit; // Update the last pressed button

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
        button7.interactable = false;
        button2.interactable = false;
        button1A.interactable = false;
        button9.interactable = false;
        button1B.interactable = false;
        button4.interactable = false;
    }
}
