using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslationManager : MonoBehaviour
{
    public static  TranslationManager instance;
    
    public Text languages1;

    public Text languages2;

    public Text languages3;

    public Text languages4;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

     public void AddTranslation(TranslationsScriptable translate)
    {
        languages1.text = translate.language1;

        languages2.text = translate.language2;

        languages3.text = translate.language3;

        languages4.text = translate.language4;
    }
}
