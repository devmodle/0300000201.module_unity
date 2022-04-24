using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if EXTRA_SCRIPT_ENABLE
namespace Etc {
	/** 페이스 북 씬 관리자 */
	public class CEFacebookSceneManager : StudyScene.CStudySceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_E_FACEBOOK;
		#endregion			// 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
#if FACEBOOK_MODULE_ENABLE
				this.ScrollViewContents.ExFindComponent<Button>("LoginBtn").onClick.AddListener(() => {
					Func.FacebookLogin((a_oSender, a_bIsSuccess) => Func.ShowAlertPopup($"Login: {a_bIsSuccess}", null, false));
				});

				this.ScrollViewContents.ExFindComponent<Button>("LogoutBtn").onClick.AddListener(() => {
					Func.FacebookLogout((a_oSender) => Func.ShowAlertPopup("Logout", null, false));
				});
#endif			// #if FACEBOOK_MODULE_ENABLE
			}
		}
		#endregion			// 함수
	}
}
#endif			// #if EXTRA_SCRIPT_ENABLE
