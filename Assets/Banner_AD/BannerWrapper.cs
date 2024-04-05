using System;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System.Collections;

public class BannerWrapper : MonoBehaviour
{
    public BannerView bannerView;

#if UNITY_ANDROID
        private const string _adUnitId = "ca-app-pub-8197512856777911/5768547360";
#elif UNITY_IPHONE
        private const string _adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
        private const string _adUnitId = "unused";
#endif

    private void Awake()
    {
        MobileAds.Initialize((InitializationStatus initStatus) => { });
    }

    void Start()
    {
        Load_AD();

        InvokeRepeating("Load_AD", 61.0f, 61.0f);
    }

    private void Load_AD()
    {
        bannerView = new BannerView(_adUnitId, AdSize.Banner, AdPosition.Top);
        AdRequest request = new AdRequest();
        bannerView.LoadAd(request);
        bannerView.Hide();

        Debug.Log("Chalia 60 sec baad");
    }

}
