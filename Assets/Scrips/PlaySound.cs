using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

    public AudioSource clickSource;
    public AudioSource bumpSource;
    public AudioSource tapSource;
    public AudioSource overSource;
    public AudioSource bgMusic;

    public static PlaySound _instance;

    void Awake()
    {
        _instance = this;
    }


    void Start() {

       // PlayBg();
    }

  public  void PlayBg() {
      bgMusic.Play();
    }

  public  void PauseBg() {
      bgMusic.Stop();
    }

    public void PlayerClick() {

        clickSource.Play();
    }

    public void PlayBump() {
        bumpSource.Play();
    
    }

    public void PlayTap()
    {
        tapSource.Play();

    }

    public void PlayOver()
    {
        overSource.Play();

    }

}
