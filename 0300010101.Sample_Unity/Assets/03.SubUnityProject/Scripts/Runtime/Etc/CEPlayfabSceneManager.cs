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
						Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
					});
				});

				this.UIs.ExFindComponent<Button>("LogoutBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();
					CPlayfabManager.Inst.Logout((a_oSender) => CIndicatorManager.Inst.Close());
				});

				this.UIs.ExFindComponent<Button>("SendLogBtn").onClick.AddListener(() => {
					CPlayfabManager.Inst.SendLog("SampleLog", LogFunc.MakeDefDatas());
				});

				this.UIs.ExFindComponent<Button>("SendAppLogBtn").onClick.AddListener(() => {
					CPlayfabManager.Inst.SendAppLog("SampleAppLog", LogFunc.MakeDefDatas());
				});

				this.UIs.ExFindComponent<Button>("SendCharacterLogBtn").onClick.AddListener(() => {
					CPlayfabManager.Inst.SendCharacterLog("SampleCharacterLog", m_oCharacterID, LogFunc.MakeDefDatas());
				});

				// this.UIs.ExFindComponent<Button>("LoadCharactersBtn").onClick.AddListener(() => {
				// 	CIndicatorManager.Inst.Show();

				// 	CPlayfabManager.Inst.LoadCharacters((a_oSender, a_oResult, a_bIsSuccess) => {
				// 		CIndicatorManager.Inst.Close();
				// 		m_oCharacterID = (a_oResult as ListUsersCharactersResult).Characters[0].CharacterId;

				// 		Func.ShowAlertPopup($"{a_bIsSuccess}, {m_oCharacterID}", null, false);
				// 	});
				// });
				
				// this.UIs.ExFindComponent<Button>("AddNumItemsBtn").onClick.AddListener(() => {
				// 	CIndicatorManager.Inst.Show();
				// 	m_nNumItems += 1;

				// 	CPlayfabManager.Inst.AddNumItems(m_oCharacterID, "Sample", m_nNumItems, (a_oSender, a_oResult, a_bIsSuccess) => {
				// 		CIndicatorManager.Inst.Close();
				// 		Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
				// 	});
				// });

				// this.UIs.ExFindComponent<Button>("BuyItemBtn").onClick.AddListener(() => {
				// 	CIndicatorManager.Inst.Show();

				// 	CPlayfabManager.Inst.BuyItem("GOODS_COINS", string.Empty, "0.0.1", 0, (a_oSender, a_oResult, a_bIsSuccess) => {
				// 		CIndicatorManager.Inst.Close();
				// 		Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
				// 	});
				// });

				// this.UIs.ExFindComponent<Button>("BuyCharacterBtn").onClick.AddListener(() => {
				// 	CIndicatorManager.Inst.Show();

				// 	CPlayfabManager.Inst.BuyCharacter("PlayfabMCharacter", "0.0.1", 0, (a_oSender, a_oResult, a_bIsSuccess) => {
				// 		CIndicatorManager.Inst.Close();
				// 		Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
				// 	});

				// 	// CPlayfabManager.Inst.MakeCharacter("Sample", "Warrior", (a_oSender, a_oResult, a_bIsSuccess) => {
				// 	// 	CIndicatorManager.Inst.Close();
				// 	// 	Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
				// 	// });
				// });

				// this.UIs.ExFindComponent<Button>("RemoveCharacterBtn").onClick.AddListener(() => {
				// 	CIndicatorManager.Inst.Show();

				// 	// CPlayfabManager.Inst.RemoveCharacter(m_oCharacterID, (a_oSender, a_oResult, a_bIsSuccess) => {
				// 	// 	CIndicatorManager.Inst.Close();
				// 	// 	Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
				// 	// });
				// });

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
