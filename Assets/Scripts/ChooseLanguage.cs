using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChooseLanguage : MonoBehaviour
{
    [SerializeField]
    private GameObject[] btnLanguageGameObjects;


    public void Language(string language)
    {
        GameManager.instance.setLanguague(language);
    }

    public void ChangeBtnUI(int language)
    {
        DisableAllLanguageButtons();
        btnLanguageGameObjects[language].SetActive(true);
    }

    public void DisableAllLanguageButtons()
    {
        for(int i = 0; i < btnLanguageGameObjects.Length; i++)
        {
            btnLanguageGameObjects[i].SetActive(false); 
        }
    }
}
