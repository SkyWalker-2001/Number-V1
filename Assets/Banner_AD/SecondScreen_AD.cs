using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondScreen_AD : MonoBehaviour
{

    void Start()
    {

        GameObject myGameObject = GameObject.Find("myBannerAdObject");

        BannerWrapper bannerWrapper = myGameObject.GetComponent<BannerWrapper>();

        if (bannerWrapper.bannerView != null)
        {
            bannerWrapper.bannerView.Show();
        }

    }
}
