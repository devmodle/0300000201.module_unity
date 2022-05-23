using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Google {
	/** 파이어 베이스 씬 관리자 */
	public class CGFirebaseSceneManager : StudyScene.CStudySceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_G_FIREBASE;
		#endregion			// 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
#if FIREBASE_MODULE_ENABLE
				this.UIs.ExFindComponent<Button>("LoginBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CFirebaseManager.Inst.Login(CCommonAppInfoStorage.Inst.AppInfo.DeviceID, (a_oSender, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();
						Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
					});
				});

				this.UIs.ExFindComponent<Button>("LogoutBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();
					CFirebaseManager.Inst.Logout((a_oSender) => CIndicatorManager.Inst.Close());
				});

				this.UIs.ExFindComponent<Button>("SaveUserInfoBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					Func.SaveUserInfo((a_oSender, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();
						Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
					});
				});

				this.UIs.ExFindComponent<Button>("LoadUserInfoBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					Func.LoadUserInfo((a_oSender, a_oJSONStr, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();
						Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
					});
				});

#if APPLE_LOGIN_ENABLE
				this.UIs.ExFindComponent<Button>("LoginWithAppleBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CServicesManager.Inst.LoginWithApple((a_oSender, a_bIsSuccess) => {
						// 로그인 되었을 경우
						if(a_bIsSuccess) {
							CFirebaseManager.Inst.LoginWithApple(CServicesManager.Inst.AppleUserID, CServicesManager.Inst.AppleIDToken, (a_oFirebaseSender, a_bIsFirebaseSuccess) => {
								CIndicatorManager.Inst.Close();
								Func.ShowAlertPopup($"{a_bIsFirebaseSuccess}", null, false);
							});
						} else {
							CIndicatorManager.Inst.Close();
							Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
						}
					});

					Func.FirebaseLogin((a_oSender, a_bIsSuccess) => Func.ShowAlertPopup($"{a_bIsSuccess}", null, false));
				});
#endif			// #if APPLE_LOGIN_ENABLE

#if FACEBOOK_MODULE_ENABLE
				this.UIs.ExFindComponent<Button>("LoginWithFacebookBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CFacebookManager.Inst.Login(KCDefine.U_PERMISSION_LIST_FACEBOOK, (a_oSender, a_bIsSuccess) => {
						// 로그인 되었을 경우
						if(a_bIsSuccess) {
							CFirebaseManager.Inst.LoginWithFacebook(CFacebookManager.Inst.AccessToken, (a_oBackendSender, a_bIsBackendSuccess) => {
								CIndicatorManager.Inst.Close();
								Func.ShowAlertPopup($"{a_bIsBackendSuccess}", null, false);
							});
						} else {
							CIndicatorManager.Inst.Close();
							Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
						}
					});
				});
#endif			// #if FACEBOOK_MODULE_ENABLE
#endif			// #if FIREBASE_MODULE_ENABLE
			}
		}
		#endregion			// 함수
	}
}
#endif			// #if EXTRA_SCRIPT_MODULE_ENABLE
