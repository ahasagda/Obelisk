using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceMovements : MonoBehaviour
{
    public AudioSource A_1;
    public KeywordRecognizer keywordRecognizer;
    public Dictionary<string, Action> actions = new Dictionary<string, Action>();//t�r�

string [] keywords = {"A", "B", "C", "D"};


    public void RecognizePart()
    {
        //actions.Add("a", A);//this works
    
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
        //keywords = {"A", "B", "C", "D"};
        //string bla = "blabla";
        string.
        //char[] character = bla.ToArray();

    }

    public void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        if (keywords.Find(speech.text))
        {
            if (keywords = A)
            {
                AudioPlay.ASound();
            }
        }
        /*char [] character = speech.text.ToArray();
        foreach (char x in character)
        {
            if (character = A)
            {
                AudioPlay.ASound();
            }
        }*/
        //Debug.Log(speech.text);
        //actions[speech.text].Invoke();

        //var word = speech.text.ToArray();
    }

    /*public void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();

        var word = speech.text.ToArray();
    }*/

    }