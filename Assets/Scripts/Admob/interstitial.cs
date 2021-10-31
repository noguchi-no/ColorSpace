using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class interstitial : MonoBehaviour
{
    private InterstitialAd Interstitial;

    public static int game = 0;
    private void Start()
    {
        Debug.Log("ÉQÅ[ÉÄâÒêîÇÕ" + game);
        if (game == 3)
        {
            GameOver();
            game = 0;
        }
    }

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.Interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.Interstitial.LoadAd(request);
    }
    public void GameOver()
    {
        if (this.Interstitial.IsLoaded())
        {
            this.Interstitial.Show();
        }
    }
}
