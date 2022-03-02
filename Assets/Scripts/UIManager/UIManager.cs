using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Auth;
using TMPro;

public class UIManager : MonoBehaviour
{
 public static UIManager instance;

// User display
public FirebaseUser User;
public TMP_Text usernameText;

 //Screen object variables
 public GameObject loginUI;
 public GameObject registerUI;

 public GameObject menuUI;

 public GameObject startUI;

 public GameObject userUI;

 public GameObject levelsUI;

 public GameObject tutorialUI;



 private void Awake()
 {
  if (instance == null)
  {
   instance = this;
  }
  else if (instance != null)
  {
   Debug.Log("Instance already exists, destroying object!");
   Destroy(this);
  }
 }

 //Functions to change the login screen UI
 public void LoginScreen() //Back button
 {
  registerUI.SetActive(false);
  loginUI.SetActive(true);
 }
 public void RegisterScreen() // Regester button
 {
  loginUI.SetActive(false);
  registerUI.SetActive(true);
 }

 public void StartScreenLogin()
 {
  loginUI.SetActive(false);
  menuUI.SetActive(true);
 }

 public void StartScreenRegister()
 {
  registerUI.SetActive(false);
  menuUI.SetActive(true);
 }

 public void MainMenuScreen()
 {
  startUI.SetActive(false);
  menuUI.SetActive(true);
 }

 public void UserToLoginScreen()
 {
  userUI.SetActive(false);
  loginUI.SetActive(true);
 }

 public void LevelsToUserScreen()
 {
  //usernameText.text = User.DisplayName;
  levelsUI.SetActive(false);
  userUI.SetActive(true);
 }
 public void LevelsScreen()
 {
  userUI.SetActive(false);
  levelsUI.SetActive(true);
 }
public void tutorialScreen()
{
 levelsUI.SetActive(false);
 tutorialUI.SetActive(true);
}

public void tutorialToLevelsScreen(){
 tutorialUI.SetActive(false);
 levelsUI.SetActive(true);
}
}
