using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 public CharacterController characterController;
 private float characterSpeed = 10f;
 void Update()
 {
  // Get A, D keyboards and mouse. 
  float x = Input.GetAxis("Horizontal");
  float z = Input.GetAxis("Vertical");

  Vector3 movement = transform.right * x + transform.forward * z;
  characterController.Move(movement * characterSpeed * Time.deltaTime);

 }
}
