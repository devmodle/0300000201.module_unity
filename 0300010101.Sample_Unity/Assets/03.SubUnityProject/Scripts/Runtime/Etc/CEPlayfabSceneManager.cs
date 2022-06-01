using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if EXTRA_SCRIPT_MODULE_ENABLE
using PlayFab.ClientModels;

namespace Etc {
	/** 플레이 팹 씬 관리자 */
	public class CEPlayfabSceneManager : StudyScene.CStudySceneManager {
		#region 변수
		private int m_nNumItems = 0;
		private string m_oCharacterID = string.Empty;
		#endregion			// 변수

		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_E_PLAYFAB;
		#endregion			// 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
#if PLAYFAB_MODULE_ENABLE
				this.UIs.ExFindComponent<Button>("LoginBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CPlayfabManager.Inst.Login(CCommonAppInfoStorage.Inst.AppInfo.DeviceID, (a_oSender, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();
						CFunc.ShowLog($"CEPlayfabSceneManager.Login: {a_bIsSuccess}");
					});
				});

				this.UIs.ExFindComponent<Button>("LogoutBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CPlayfabManager.Inst.Logout((a_oSender) => {
						CIndicatorManager.Inst.Close();
						CFunc.ShowLog($"CEPlayfabSceneManager.Logout");
					});
				});

				this.UIs.ExFindComponent<Button>("SendLogBtn").onClick.AddListener(() => {
					CPlayfabManager.Inst.SendLog("SampleLog", LogFunc.MakeDefDatas());
				});

				this.UIs.ExFindComponent<Button>("SendUserLogBtn").onClick.AddListener(() => {
					CPlayfabManager.Inst.SendUserLog("SampleUserLog", LogFunc.MakeDefDatas());
				});

				this.UIs.ExFindComponent<Button>("SendCharacterLogBtn").onClick.AddListener(() => {
					CPlayfabManager.Inst.SendCharacterLog("SampleCharacterLog", m_oCharacterID, LogFunc.MakeDefDatas());
				});

				this.UIs.ExFindComponent<Button>("LoadDatasBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CPlayfabManager.Inst.LoadDatas(new List<string>() { "Sample" }, (a_oSender, a_oResult, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();
						CFunc.ShowLog($"CEPlayfabSceneManager.LoadDatas: {a_oResult?.ToJson()}, {a_bIsSuccess}");
					});
				});

				this.UIs.ExFindComponent<Button>("LoadNoticesBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CPlayfabManager.Inst.LoadNotices((a_oSender, a_oResult, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();
						CFunc.ShowLog($"CEPlayfabSceneManager.LoadNotices: {a_oResult?.ToJson()}, {a_bIsSuccess}");
					});
				});

				this.UIs.ExFindComponent<Button>("LoadLeaderboardBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CPlayfabManager.Inst.LoadLeaderboard("LogTime", (a_oSender, a_oResult, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();
						CFunc.ShowLog($"CEPlayfabSceneManager.LoadLeaderboard: {a_oResult?.ToJson()}, {a_bIsSuccess}");
					});
				});

				this.UIs.ExFindComponent<Button>("LoadServerTimeBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CPlayfabManager.Inst.LoadServerTime((a_oSender, a_oResult, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();
						CFunc.ShowLog($"CEPlayfabSceneManager.LoadServerTime: {a_oResult?.ToJson()}, {a_bIsSuccess}");
					});
				});

				this.UIs.ExFindComponent<Button>("LoadUserDatasBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CPlayfabManager.Inst.LoadUserDatas(new List<string>() { "Sample" }, (a_oSender, a_oResult, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();
						CFunc.ShowLog($"CEPlayfabSceneManager.LoadUserDatas: {a_oResult?.ToJson()}, {a_bIsSuccess}");
					});
				});

				this.UIs.ExFindComponent<Button>("LoadUserItemsBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CPlayfabManager.Inst.LoadUserItems((a_oSender, a_oResult, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();
						CFunc.ShowLog($"CEPlayfabSceneManager.LoadUserItems: {a_oResult?.ToJson()}, {a_bIsSuccess}");
					});
				});

				this.UIs.ExFindComponent<Button>("LoadUserCharactersBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CPlayfabManager.Inst.LoadUserCharacters((a_oSender, a_oResult, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();

						// 로드 되었을 경우
						if(a_bIsSuccess) {
							m_oCharacterID = (a_oResult as ListUsersCharactersResult).Characters[KCDefine.B_VAL_0_INT].CharacterId;
						}

						CFunc.ShowLog($"CEPlayfabSceneManager.LoadUserCharacters: {a_oResult?.ToJson()}, {a_bIsSuccess}");
					});
				});

				this.UIs.ExFindComponent<Button>("LoadUserSegmentsBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CPlayfabManager.Inst.LoadUserSegments((a_oSender, a_oResult, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();
						CFunc.ShowLog($"CEPlayfabSceneManager.LoadUserSegments: {a_oResult?.ToJson()}, {a_bIsSuccess}");
					});
				});

				this.UIs.ExFindComponent<Button>("BuyUserCharacterBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CPlayfabManager.Inst.BuyUserCharacter("CHARACTER_NORM", "Sample", "GC", (a_oSender, a_oResult, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();

						// 구입 되었을 경우
						if(a_bIsSuccess) {
							m_oCharacterID = (a_oResult as GrantCharacterToUserResult).CharacterId;
						}

						CFunc.ShowLog($"CEPlayfabSceneManager.BuyUserCharacter: {a_oResult?.ToJson()}, {a_bIsSuccess}");
					});
				});

				this.UIs.ExFindComponent<Button>("LoadCharacterDatasBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CPlayfabManager.Inst.LoadCharacterDatas(m_oCharacterID, new List<string>() { "Sample" }, (a_oSender, a_oResult, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();
						CFunc.ShowLog($"CEPlayfabSceneManager.LoadUserDatas: {a_oResult?.ToJson()}, {a_bIsSuccess}");
					});
				});

#if APPLE_LOGIN_ENABLE
				this.UIs.ExFindComponent<Button>("LoginWithAppleBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CServicesManager.Inst.LoginWithApple((a_oSender, a_bIsSuccess) => {
						// 로그인 되었을 경우
						if(a_bIsSuccess) {
							CPlayfabManager.Inst.LoginWithApple(CServicesManager.Inst.AppleUserID, CServicesManager.Inst.AppleIDToken, (a_oPlayfabSender, a_bIsPlayfabSuccess) => {
								CIndicatorManager.Inst.Close();
								Func.ShowAlertPopup($"{a_bIsPlayfabSuccess}", null, false);
							});
						} else {
							CIndicatorManager.Inst.Close();
							Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
						}
					});

					Func.PlayfabLogin((a_oSender, a_bIsSuccess) => Func.ShowAlertPopup($"{a_bIsSuccess}", null, false));
				});
#endif			// #if APPLE_LOGIN_ENABLE

#if FACEBOOK_MODULE_ENABLE
				this.UIs.ExFindComponent<Button>("LoginWithFacebookBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CFacebookManager.Inst.Login(KCDefine.U_PERMISSION_LIST_FACEBOOK, (a_oSender, a_bIsSuccess) => {
						// 로그인 되었을 경우
						if(a_bIsSuccess) {
							CPlayfabManager.Inst.LoginWithFacebook(CFacebookManager.Inst.AccessToken, (a_oPlayfabSender, a_bIsPlayfabSuccess) => {
								CIndicatorManager.Inst.Close();
								Func.ShowAlertPopup($"{a_bIsPlayfabSuccess}", null, false);
							});
						} else {
							CIndicatorManager.Inst.Close();
							Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
						}
					});
				});
#endif			// #if FACEBOOK_MODULE_ENABLE
#endif			// #if PLAYFAB_MODULE_ENABLE
			}
		}
		#endregion			// 함수
	}
}
#endif			// #if EXTRA_SCRIPT_MODULE_ENABLE
