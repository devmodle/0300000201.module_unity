using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Ads
{
	/** 애드 몹 씬 관리자 */
	public partial class CAdsAdmobSceneManager : ResearchScene.CRSceneManager
	{
		/** 식별자 */
		private enum EKey
		{
			NONE = -1,
			[HideInInspector] MAX_VAL
		}

		#region 변수

		#endregion // 변수

		#region 프로퍼티

		#endregion // 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake()
		{
			base.Awake();

			// 앱 초기화가 필요 할 경우
			if(!CSceneManager.IsInitApp)
			{
				return;
			}

			// 버튼을 설정한다
			CFunc.SetupButtons(new List<(string, GameObject, UnityAction)>()
			{
				("LOAD_BANNER_ADS", this.UIs, this.OnTouchLoadBannerAdsBtn),
				("LOAD_FULLSCREEN_ADS", this.UIs, this.OnTouchLoadFullscreenAdsBtn),
				("LOAD_REWARD_ADS", this.UIs, this.OnTouchLoadRewardAdsBtn),

				("SHOW_BANNER_ADS", this.UIs, this.OnTouchShowBannerAdsBtn),
				("SHOW_FULLSCREEN_ADS", this.UIs, this.OnTouchShowFullscreenAdsBtn),
				("SHOW_REWARD_ADS", this.UIs, this.OnTouchShowRewardAdsBtn),

				("CLOSE_BANNER_ADS", this.UIs, this.OnTouchCloseBannerAdsBtn)
			});
		}

		/** 초기화 */
		public override void Start()
		{
			base.Start();

			// 앱 초기화가 필요 할 경우
			if(!CSceneManager.IsInitApp)
			{
				return;
			}

			this.UpdateUIsState();
		}

		/** 제거되었을 경우 */
		public override void OnDestroy()
		{
			base.OnDestroy();

			try
			{
				// 앱이 종료되었을 경우
				if(!CSceneManager.IsRunningApp)
				{
					return;
				}
			}
			catch(System.Exception oException)
			{
				CFunc.ShowLogWarning($"CAdsAdmobSceneManager.OnDestroy Exception: {oException.Message}");
			}
		}

		/** 상태를 갱신한다 */
		public override void OnUpdate(float a_fTimeDelta)
		{
			base.OnUpdate(a_fTimeDelta);

			// 앱이 종료되었을 경우
			if(!CSceneManager.IsRunningApp)
			{
				return;
			}
		}

		/** 내비게이션 스택 이벤트를 수신했을 경우 */
		public override void OnReceiveEventNavStack(EEventNavStack a_eEvent)
		{
			base.OnReceiveEventNavStack(a_eEvent);

			// 백 키 눌림 이벤트 일 경우
			if(a_eEvent == EEventNavStack.BACK_KEY_DOWN)
			{
				// Do Something
			}
		}

		/** UI 상태를 갱신한다 */
		private void UpdateUIsState()
		{
			// Do Something
		}

		/** 배너 광고 로드 버튼을 눌렀을 경우 */
		private void OnTouchLoadBannerAdsBtn()
		{
#if ADS_MODULE_ENABLE
			Func.LoadBannerAds(EAdsPlatform.ADMOB);
#endif // #if ADS_MODULE_ENABLE
		}

		/** 전면 광고 로드 버튼을 눌렀을 경우 */
		private void OnTouchLoadFullscreenAdsBtn()
		{
#if ADS_MODULE_ENABLE
			Func.LoadFullscreenAds(EAdsPlatform.ADMOB);
#endif // #if ADS_MODULE_ENABLE
		}

		/** 보상 광고 로드 버튼을 눌렀을 경우 */
		private void OnTouchLoadRewardAdsBtn()
		{
#if ADS_MODULE_ENABLE
			Func.LoadRewardAds(EAdsPlatform.ADMOB);
#endif // #if ADS_MODULE_ENABLE
		}

		/** 배너 광고 출력 버튼을 눌렀을 경우 */
		private void OnTouchShowBannerAdsBtn()
		{
#if ADS_MODULE_ENABLE
			Func.ShowBannerAds(EAdsPlatform.ADMOB, (a_oSender, a_bIsSuccess) => {
				CUnityMsgSender.Inst.SendShowToastMsg($"{a_bIsSuccess}");
			});
#endif // #if ADS_MODULE_ENABLE
		}

		/** 전면 광고 출력 버튼을 눌렀을 경우 */
		private void OnTouchShowFullscreenAdsBtn()
		{
#if ADS_MODULE_ENABLE
			Func.ShowFullscreenAds(EAdsPlatform.ADMOB, (a_oSender, a_bIsSuccess) => {
				CUnityMsgSender.Inst.SendShowToastMsg($"{a_bIsSuccess}");
			});
#endif // #if ADS_MODULE_ENABLE
		}

		/** 보상 광고 출력 버튼을 눌렀을 경우 */
		private void OnTouchShowRewardAdsBtn()
		{
#if ADS_MODULE_ENABLE
			Func.ShowRewardAds(EAdsPlatform.ADMOB, (a_oSender, a_stAdsRewardInfo, a_bIsSuccess) => {
				CUnityMsgSender.Inst.SendShowToastMsg($"{a_bIsSuccess}");
			});
#endif // #if ADS_MODULE_ENABLE
		}

		/** 배너 광고 닫기 버튼을 눌렀을 경우 */
		private void OnTouchCloseBannerAdsBtn()
		{
#if ADS_MODULE_ENABLE
			Func.CloseBannerAds(EAdsPlatform.ADMOB, (a_oSender, a_bIsSuccess) => {
				CUnityMsgSender.Inst.SendShowToastMsg($"{a_bIsSuccess}");
			});
#endif // #if ADS_MODULE_ENABLE
		}
		#endregion // 함수
	}
}
#endif // #if EXTRA_SCRIPT_MODULE_ENABLE
