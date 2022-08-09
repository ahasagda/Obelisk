using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceRecognizer : MonoBehaviour
{
    
    public KeywordRecognizer keywordRecognizer;
    public Dictionary<string, Action> actions = new Dictionary<string, Action>();//t�r�

    void Start()
    {
    //    actions.Add("Left", Left);//this works
    
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();

    }

    public void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();

        var word = speech.text.ToArray();
        foreach (char x in word)
        {
            system.Console.Write(x + '\n');
        }
    }

    /*private void Left()
    {
        Debug.Log("Left");
    }*/

}
            /*switch (val)
            {
            case 1:
                PlaySound(A_1);
                System.Console.WriteLine(A_1);
                break;
            case 2:
                PlaySound(b);
                break;
            case 3:
                PlaySound(C);
                break;
            case 4:
                PlaySound(D);
                break;
            case 5:
            System.Console.WriteLine("Beş");
                break;
            default:
            System.Console.WriteLine("Hiçbiri");
                break;
            }*/
