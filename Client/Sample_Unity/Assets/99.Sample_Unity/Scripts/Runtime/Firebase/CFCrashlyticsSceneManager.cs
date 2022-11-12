using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Firebase {
	/** 크래시 씬 관리자 */
	public partial class CFCrashlyticsSceneManager : StudyScene.CSSceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_F_ANALYTICS;
		#endregion         // 프로퍼티                 

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
				this.UIs.ExFindComponent<Button>("SEND_CRASH_LOG_BTN")?.onClick.AddListener(this.OnTouchSendCrashLogBtn);
			}
		}

		/** 크래시 로그 전송 버튼을 눌렀을 경우 */
		public void OnTouchSendCrashLogBtn() {
			throw new System.Exception("Sample");
		}
		#endregion         // 함수               
	}
}
#endif         // #if EXTRA_SCRIPT_MODULE_ENABLE                                           
