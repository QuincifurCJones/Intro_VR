using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Start_Game : MonoBehaviour
{
    public InputActionReference triggerLeft;
    public InputActionReference triggerRight;
    [SerializeField] public string Next_Scene;

    // Update is called once per frame
    void Update()
    {
        float leftTriggerHeld = triggerLeft.action.ReadValue<float>();
        float rightTriggerHeld = triggerRight.action.ReadValue<float>();

        if (leftTriggerHeld > 0.1 && rightTriggerHeld > 0.5) {
            SceneManager.LoadScene("Scenes/MainScene");
            //SceneManager.LoadScene(Next_Scene);
        }
    }
}