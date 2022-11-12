using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Ads {
	/** 애드 몹 광고 씬 관리자 */
	public partial class CAAdmobSceneManager : StudyScene.CSSceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_A_ADMOB;
		#endregion            // 프로퍼티                 

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
				this.UIs.ExFindComponent<Button>("LOAD_BANNER_ADS_BTN")?.onClick.AddListener(this.OnTouchLoadBannerAdsBtn);
				this.UIs.ExFindComponent<Button>("LOAD_REWARD_ADS_BTN")?.onClick.AddListener(this.OnTouchLoadRewardAdsBtn);
				this.UIs.ExFindComponent<Button>("LOAD_FULLSCREEN_ADS_BTN")?.onClick.AddListener(this.OnTouchLoadFullscreenAdsBtn);

				this.UIs.ExFindComponent<Button>("SHOW_BANNER_ADS_BTN")?.onClick.AddListener(this.OnTouchShowBannerAdsBtn);
				this.UIs.ExFindComponent<Button>("SHOW_REWARD_ADS_BTN")?.onClick.AddListener(this.OnTouchShowRewardAdsBtn);
				this.UIs.ExFindComponent<Button>("SHOW_FULLSCREEN_ADS_BTN")?.onClick.AddListener(this.OnTouchShowFullscreenAdsBtn);

				this.UIs.ExFindComponent<Button>("CLOSE_BANNER_ADS_BTN")?.onClick.AddListener(this.OnTouchCloseBannerAdsBtn);
			}
		}

		private void OnTouchLoadBannerAdsBtn() {
#if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE
			CAdsManager.Inst.LoadBannerAds(EAdsPlatform.ADMOB);
#endif          // #if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE                                                      
		}

		private void OnTouchLoadRewardAdsBtn() {
#if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE
			CAdsManager.Inst.LoadRewardAds(EAdsPlatform.ADMOB);
#endif          // #if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE                                                      
		}

		private void OnTouchLoadFullscreenAdsBtn() {
#if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE
			CAdsManager.Inst.LoadFullscreenAds(EAdsPlatform.ADMOB);
#endif          // #if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE                                                      
		}

		private void OnTouchShowBannerAdsBtn() {
#if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE
			CAdsManager.Inst.ShowBannerAds(EAdsPlatform.ADMOB, null);
#endif          // #if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE                                                      
		}

		private void OnTouchShowRewardAdsBtn() {
#if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE
			CAdsManager.Inst.ShowRewardAds(EAdsPlatform.ADMOB, null);
#endif          // #if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE                                                      
		}

		private void OnTouchShowFullscreenAdsBtn() {
#if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE
			CAdsManager.Inst.ShowFullscreenAds(EAdsPlatform.ADMOB, null);
#endif          // #if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE                                                      
		}

		private void OnTouchCloseBannerAdsBtn() {
#if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE
			CAdsManager.Inst.CloseBannerAds(EAdsPlatform.ADMOB, null);
#endif          // #if ADS_MODULE_ENABLE && ADMOB_ADS_ENABLE                                                      
		}
		#endregion         // 함수               
	}
}
#endif          // #if EXTRA_SCRIPT_MODULE_ENABLE
