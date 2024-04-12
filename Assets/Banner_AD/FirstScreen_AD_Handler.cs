
using GoogleMobileAds.Api;
using UnityEngine;

public class FirstScreen_AD_Handler : MonoBehaviour
{
    void Start()
    {

        // Create a wrapper GameObject to hold the banner. Mark the GameObject not to be destroyed when     new scenes load.

        GameObject myGameObject = new GameObject("myBannerAdObject");

        myGameObject.AddComponent<BannerWrapper>();

        DontDestroyOnLoad(myGameObject);

    }
}
