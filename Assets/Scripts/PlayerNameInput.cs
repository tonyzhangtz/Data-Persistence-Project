using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerNameInput : MonoBehaviour
{
    public void NameInput(string s)
    {
        MainMenu.Instance.PlayerName = GameObject.Find("Name Input").GetComponent<TMP_InputField>().text;
    }
}
