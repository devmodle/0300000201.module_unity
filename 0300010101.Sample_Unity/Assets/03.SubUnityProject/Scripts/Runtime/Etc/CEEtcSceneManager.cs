using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Etc {
	/** 기타 씬 관리자 */
	public class CEEtcSceneManager : StudyScene.CStudySceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_E_ETC;
		#endregion			// 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
				this.UIs.ExFindComponent<Button>("ShowIndicatorBtn").onClick.AddListener(() => {
					CIndicatorManager.Inst.Show();
					this.ExLateCallFunc((a_oSender) => CIndicatorManager.Inst.Close(), KCDefine.B_VAL_5_FLT);
				});

#if NOTI_MODULE_ENABLE
				this.UIs.ExFindComponent<Button>("AddNotiBtn").onClick.AddListener(() => {
					CNotiManager.Inst.AddNoti($"{System.DateTime.Today.Ticks % KCDefine.B_UNIT_MICRO_SECS_PER_SEC}", new STNotiInfo() {
						m_bIsRepeat = false,
						
						m_oTitle = "Title",
						m_oSubTitle = "SubTitle",
						m_oMsg = "Msg",
						
						m_stNotiTime = System.DateTime.Now + new System.TimeSpan(0, 0, 5)
					});
				});

				this.UIs.ExFindComponent<Button>("RemoveNotiBtn").onClick.AddListener(() => {
					CNotiManager.Inst.RemoveNoti($"{System.DateTime.Today.Ticks % KCDefine.B_UNIT_MICRO_SECS_PER_SEC}");
				});
#endif			// #if NOTI_MODULE_ENABLE
			}
		}
		#endregion			// 함수
	}
}
#endif			// #if EXTRA_SCRIPT_MODULE_ENABLE
