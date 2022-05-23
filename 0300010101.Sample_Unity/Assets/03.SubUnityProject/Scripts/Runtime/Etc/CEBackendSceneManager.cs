using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Etc {
	/** 백엔드 씬 관리자 */
	public class CEBackendSceneManager : StudyScene.CStudySceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_E_BACKEND;
		#endregion			// 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
#if BACKEND_MODULE_ENABLE
				this.UIs.ExFindComponent<Button>("LoginBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CBackendManager.Inst.Login(CCommonAppInfoStorage.Inst.AppInfo.DeviceID, (a_oSender, a_bIsSuccess) => {
						CIndicatorManager.Inst.Close();
						Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
					});
				});

				this.UIs.ExFindComponent<Button>("LogoutBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();
					CBackendManager.Inst.Logout((a_oSender) => CIndicatorManager.Inst.Close());
				});

#if APPLE_LOGIN_ENABLE
				this.UIs.ExFindComponent<Button>("LoginWithAppleBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CServicesManager.Inst.LoginWithApple((a_oSender, a_bIsSuccess) => {
						// 로그인 되었을 경우
						if(a_bIsSuccess) {
							CBackendManager.Inst.LoginWithApple(CServicesManager.Inst.AppleUserID, CServicesManager.Inst.AppleIDToken, (a_oBackendSender, a_bIsBackendSuccess) => {
								CIndicatorManager.Inst.Close();
								Func.ShowAlertPopup($"{a_bIsBackendSuccess}", null, false);
							});
						} else {
							CIndicatorManager.Inst.Close();
							Func.ShowAlertPopup($"{a_bIsSuccess}", null, false);
						}
					});

					Func.BackendLogin((a_oSender, a_bIsSuccess) => Func.ShowAlertPopup($"{a_bIsSuccess}", null, false));
				});
#endif			// #if APPLE_LOGIN_ENABLE

#if FACEBOOK_MODULE_ENABLE
				this.UIs.ExFindComponent<Button>("LoginWithFacebookBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();

					CFacebookManager.Inst.Login(KCDefine.U_PERMISSION_LIST_FACEBOOK, (a_oSender, a_bIsSuccess) => {
						// 로그인 되었을 경우
						if(a_bIsSuccess) {
							CBackendManager.Inst.LoginWithFacebook(CFacebookManager.Inst.AccessToken, (a_oBackendSender, a_bIsBackendSuccess) => {
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
#endif			// #if BACKEND_MODULE_ENABLE
			}
		}
		#endregion			// 함수
	}
}
#endif			// #if EXTRA_SCRIPT_MODULE_ENABLE
