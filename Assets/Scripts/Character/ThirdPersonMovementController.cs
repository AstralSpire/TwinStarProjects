using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ThirdPersonMovementController : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float VerticalInput = Input.GetAxisRaw("Vertical");
        float HorizontalInput = Input.GetAxisRaw("Horizontal");
        Vector3 normalizedDirection = new Vector3(HorizontalInput,0f,VerticalInput).normalized;
        if (normalizedDirection.magnitude > 0)
        {
            controller.Move(normalizedDirection*speed*Time.deltaTime);
        }
    }
}
