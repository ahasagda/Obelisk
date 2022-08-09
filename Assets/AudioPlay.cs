using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioSource A_1;
    public AudioSource B;
    public AudioSource C;//check 2 files may be created
    public AudioSource D;
    public AudioSource E;
    public AudioSource F;
    public AudioSource G;
    

    // Start is called before the first frame update
    /*void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
    {
            A_1.Play();
    }
        if (Input.GetKeyDown(KeyCode.B))
    {
            B.Play();
    }
        if (Input.GetKeyDown(KeyCode.C))
    {
            C.Play();
    }
    }*/

    public void ASound()
    {
        A_1.Play();
    }
    public void BSound()
    {
        B.Play();
    }
    public void CSound()
    {
        C.Play();
    }
    public void DSound()
    {
        D.Play();
    }
    public void ESound()
    {
        E.Play();
    }
    public void FSound()
    {
        F.Play();
    }
    public void GSound()
    {
        G.Play();
    }
}
