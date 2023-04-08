using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CheckErrorController : MonoBehaviour
{
    private const string ERROR_MESSAGE = "Please check this box to continue.";

    public TMP_InputField nameInput;
    public TMP_InputField surnameInput;
    public TMP_InputField ageInput;
    public Toggle checkbox;
    public TextMeshProUGUI errorMessage;
    public TextMeshProUGUI userNameMessage;
    public TextMeshProUGUI userAgeMessage;

    private string _userName;
    private string _userSurname;
    private int _userAge;

    public void CheckError()
    {
        _userName = nameInput.text;
        _userSurname = surnameInput.text;
        _userAge = Int32.Parse(ageInput.text);

        if(!checkbox.isOn)
        {
            errorMessage.text = ERROR_MESSAGE;
        }
        else
        {
            errorMessage.text = "";
            userNameMessage.text = "Hi, " + _userName + " " + _userSurname + ", Thank you for accepting our t's and c's.";
            userAgeMessage.text = "Your age is " + _userAge + ", it's nice to meet you.";
        }
    }
}
