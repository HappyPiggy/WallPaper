using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

    public AudioSource clickSource;
    public AudioSource bumpSource;
    public AudioSource tapSource;
    public AudioSource overSource;
    public AudioSource bgMusic;
    public AudioSource damgageSource;

    public AudioSource rocketSource;
    public AudioSource angrySource;
    public AudioSource funnySource;
    public AudioSource basketballSource;

    public static PlaySound _instance;

    void Awake()
    {
        _instance = this;
    }


    public void PlayFunny()
    {
        funnySource.Play();
    }

    public void PlayBasketball()
    {
        basketballSource.Play();
    }


    public void PlayAngry()
    {
        angrySource.Play();
    }


    public void PlayRocket()
    {
        rocketSource.Play();
    }

    public void PlayDamage()
    {
        damgageSource.Play();
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
