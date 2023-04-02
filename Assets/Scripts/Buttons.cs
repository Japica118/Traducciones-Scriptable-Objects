using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Buttons : MonoBehaviour
{
    public TranslationsScriptable translate;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Translation()
    {
        TranslationManager.instance.AddTranslation(translate);
    }
}
