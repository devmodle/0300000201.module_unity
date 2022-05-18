using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Etc {
	/** 알림 씬 관리자 */
	public class CENotiSceneManager : StudyScene.CStudySceneManager {
		#region 변수
		private int m_nNum = 0;
		#endregion			// 변수

		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_E_NOTI;
		#endregion			// 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
#if NOTI_MODULE_ENABLE
				this.UIs.ExFindComponent<Button>("AddNotiBtn").onClick.AddListener(() => {
					m_nNum += 1;

					CNotiManager.Inst.AddNoti($"{System.DateTime.Today.Ticks}", new STNotiInfo() {
						m_bIsRepeat = false,
						
						m_oTitle = "Title",
						m_oSubTitle = "SubTitle",
						m_oMsg = $"Msg_{m_nNum:00}",
						
						m_stNotiTime = System.DateTime.Now + new System.TimeSpan(0, 0, 5)
					});
				});

				this.UIs.ExFindComponent<Button>("AddUniqueNotiBtn").onClick.AddListener(() => {
					m_nNum += 1;
					
					CNotiManager.Inst.AddNoti($"{System.DateTime.Now.Ticks}", new STNotiInfo() {
						m_bIsRepeat = false,
						
						m_oTitle = "Title",
						m_oSubTitle = "SubTitle",
						m_oMsg = $"Msg_{m_nNum:00}",
						
						m_stNotiTime = System.DateTime.Now + new System.TimeSpan(0, 0, 5)
					});
				});

				this.UIs.ExFindComponent<Button>("RemoveNotiBtn").onClick.AddListener(() => {
					CNotiManager.Inst.RemoveNoti($"{System.DateTime.Today.Ticks}");
				});
#endif			// #if NOTI_MODULE_ENABLE
			}
		}
		#endregion			// 함수
	}
}
#endif			// #if EXTRA_SCRIPT_MODULE_ENABLE
