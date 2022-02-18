using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region variables
        // variable declaration
        public float moveSpeed = 1;
        // getting input from the player
        public float xInput;
        public float zInput;
        public Vector3 moveDirection;
        public CharacterController characterController;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        // variable definition
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        moveDirection = new Vector3(xInput, 0, zInput);
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
}
