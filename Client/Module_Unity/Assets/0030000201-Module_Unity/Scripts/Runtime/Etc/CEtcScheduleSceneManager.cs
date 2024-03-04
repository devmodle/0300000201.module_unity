using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Etc {
	/** 스케줄 씬 관리자 */
	public partial class CEtcScheduleSceneManager : ResearchScene.CRSceneManager {
		/** 식별자 */
		private enum EKey {
			NONE = -1,
			[HideInInspector] MAX_VAL
		}

		#region 변수

		#endregion // 변수

		#region 프로퍼티
		
		#endregion // 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화되었을 경우
			if(CSceneManager.IsAppInit) {
				// 버튼을 설정한다
				CFunc.SetupButtons(new List<(string, GameObject, UnityAction)>() {
					("ADD_TIMER_BTN", this.UIs, this.OnTouchAddTimerBtn),
					("ADD_REPEAT_TIMER_BTN", this.UIs, this.OnTouchAddRepeatTimerBtn),

					("REMOVE_TIMER_BTN", this.UIs, this.OnTouchRemoveTimerBtn),
					("REMOVE_REPEAT_TIMER_BTN", this.UIs, this.OnTouchRemoveRepeatTimerBtn)
				});
			}
		}

		/** 초기화 */
		public override void Start() {
			base.Start();

			// 앱이 초기화되었을 경우
			if(CSceneManager.IsAppInit) {
				this.UpdateUIsState();
			}
		}

		/** 제거되었을 경우 */
		public override void OnDestroy() {
			base.OnDestroy();

			try {
				// 앱이 실행 중 일 경우
				if(CSceneManager.IsAppRunning) {
					// Do Something
				}
			} catch(System.Exception oException) {
				CFunc.ShowLogWarning($"CEtcScheduleSceneManager.OnDestroy Exception: {oException.Message}");
			}
		}

		/** 상태를 갱신한다 */
		public override void OnUpdate(float a_fDeltaTime) {
			base.OnUpdate(a_fDeltaTime);

			// 앱이 실행 중 일 경우
			if(CSceneManager.IsAppRunning) {
				// Do Something
			}
		}

		/** 내비게이션 스택 이벤트를 수신했을 경우 */
		public override void OnReceiveNavStackEvent(ENavStackEvent a_eEvent) {
			base.OnReceiveNavStackEvent(a_eEvent);

			// 백 키 눌림 이벤트 일 경우
			if(a_eEvent == ENavStackEvent.BACK_KEY_DOWN) {
				// Do Something
			}
		}

		/** UI 상태를 갱신한다 */
		private void UpdateUIsState() {
			// Do Something
		}

		/** 타이머 추가 버튼을 눌렀을 경우 */
		private void OnTouchAddTimerBtn() {
			CScheduleManager.Inst.AddTimer(this, 1.0f, 1, this.OnExecuteTimer);
		}

		/** 반복 타이머 추가 버튼을 눌렀을 경우 */
		private void OnTouchAddRepeatTimerBtn() {
			CScheduleManager.Inst.AddRepeatTimer(this, 1.0f, this.OnExecuteRepeatTimer);
		}

		/** 타이머 제거 버튼을 눌렀을 경우 */
		private void OnTouchRemoveTimerBtn() {
			CScheduleManager.Inst.RemoveTimer(this);
		}

		/** 반복 타이머 제거 버튼을 눌렀을 경우 */
		private void OnTouchRemoveRepeatTimerBtn() {
			CScheduleManager.Inst.RemoveTimer(this.OnExecuteRepeatTimer);
		}

		/** 타이머가 실행되었을 경우 */
		private void OnExecuteTimer() {
			CFunc.ShowLog($"CEtcScheduleSceneManager.OnExecuteTimer");
		}

		/** 반복 타이머가 실행되었을 경우 */
		private void OnExecuteRepeatTimer() {
			CFunc.ShowLog($"CEtcScheduleSceneManager.OnExecuteRepeatTimer");
		}
		#endregion // 함수
	}
}
#endif // #if EXTRA_SCRIPT_MODULE_ENABLE
