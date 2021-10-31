using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class banner : MonoBehaviour
{
    private BannerView bannerView;
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        this.RequestBanner();
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3940256099942544/6300978111";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-5858797465901996/2959303939";
#else
            string adUnitId = "unexpected_platform";
#endif
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();

        this.bannerView.LoadAd(request);
    }
}
