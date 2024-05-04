using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class LoadSceneOnTap : MonoBehaviour
{
    private void Update()
    {
        // Check for touch input on devices or mouse click in editor
        if (Touchscreen.current.press.isPressed || Mouse.current.leftButton.wasPressedThisFrame)
        {
            // Load scene number 15
            SceneManager.LoadScene(15);
        }
    }
}
