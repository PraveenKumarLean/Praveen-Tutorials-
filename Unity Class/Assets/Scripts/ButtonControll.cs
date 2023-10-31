using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonControll : MonoBehaviour
{
    public TextMeshProUGUI Name;

    public string Contant;

    private void OnEnable()
    {
        Name.text = Contant;
    }

}
