using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;

public class Backscript : MonoBehaviour
{
    public Button targetButton; // Assign the Button in the Inspector
    


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
        {
            
            targetButton.onClick.Invoke();
        }
    }
}
