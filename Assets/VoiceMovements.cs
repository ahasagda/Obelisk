using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;


public class VoiceMovements : MonoBehaviour
{

    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();//türü

    void Start()
    {
        actions.Add("Left", Left);//this works
    
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();

        string bla = "blabla";

        char[] character = bla.ToArray();

        
    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();

        var word = speech.text.ToArray();
        foreach (char x in word)
        {
            Debug.Log(x);
        }
    }

    private void Left()
    {
        Debug.Log("Left");
    }

   

}
