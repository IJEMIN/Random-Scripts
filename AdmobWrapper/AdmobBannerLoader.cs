//Add Symbol "USING_GOOGLE_MOBILE_ADS" to Build Setting after import GoogleMobileAds library from here https://github.com/googleads/googleads-mobile-unity

#if USING_GOOGLE_MOBILE_ADS

using UnityEngine;
//using System.Collections;
using GoogleMobileAds.Api;
public class AdmobBannerLoader : MonoBehaviour {
	
	public string iOS_ID;
	public string android_ID;
	public string test_ID;


	// Use this for initialization
	void Start () {
		
#if UNITY_ANDROID
			string adUnitId = android_ID;
#elif UNITY_IPHONE
			string adUnitId = iOS_ID;
#else
			string adUnitId = "unexpected_platform";
#endif



		AdSize m_adSize = null;

		switch (adSize)
		{
			case AD_SIZE.BANNER:
				m_adSize = AdSize.Banner;
				break;
			case AD_SIZE.IAB_BANNER:
				m_adSize = AdSize.IABBanner;
				break;
			case AD_SIZE.LEADER_BOARD:
				m_adSize = AdSize.Leaderboard;
				break;
			case AD_SIZE.MEDIUM_RECTANGLE:
				m_adSize = AdSize.MediumRectangle;
				break;
			case AD_SIZE.SMART_BANNER:
				m_adSize = AdSize.SmartBanner;
				break;
		}


		BannerView bannerView = new BannerView(adUnitId, m_adSize, adPosition);

		AdRequest request = new AdRequest.Builder().AddTestDevice(test_ID).Build();
		

		bannerView.LoadAd(request);



	}

	public enum AD_SIZE
	{
		BANNER, MEDIUM_RECTANGLE, IAB_BANNER, LEADER_BOARD, SMART_BANNER
	}

	public AD_SIZE adSize = AD_SIZE.SMART_BANNER;

	public AdPosition adPosition = AdPosition.Bottom;
	
}

#endif