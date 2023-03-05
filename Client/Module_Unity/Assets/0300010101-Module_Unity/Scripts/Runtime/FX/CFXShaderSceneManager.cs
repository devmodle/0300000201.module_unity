using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace FX {
	/** 쉐이더 씬 관리자 */
	public partial class CFXShaderSceneManager : StudyScene.CSSceneManager {
		/** 식별자 */
		private enum EKey {
			NONE = -1,
			[HideInInspector] MAX_VAL
		}

		#region 변수
		/** =====> 객체 <===== */
		[SerializeField] private List<GameObject> m_oSphereList = new List<GameObject>();
		#endregion // 변수

		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_FX_SHADER;
		#endregion // 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
				// Do Something
			}
		}

		/** 초기화 */
		public override void Start() {
			base.Start();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
				this.UpdateUIsState();
			}
		}

		/** 제거 되었을 경우 */
		public override void OnDestroy() {
			base.OnDestroy();

			try {
				// 앱이 실행 중 일 경우
				if(CSceneManager.IsAppRunning) {
					// Do Something
				}
			} catch(System.Exception oException) {
				CFunc.ShowLogWarning($"CFXShaderSceneManager.OnDestroy Exception: {oException.Message}");
			}
		}

		/** 상태를 갱신한다 */
		public override void OnUpdate(float a_fDeltaTime) {
			base.OnUpdate(a_fDeltaTime);

			// 앱이 실행 중 일 경우
			if(CSceneManager.IsAppRunning) {
				for(int i = 0; i < m_oSphereList.Count; ++i) {
					m_oSphereList[i].transform.Rotate(new Vector3(0.0f, 90.0f * a_fDeltaTime, 0.0f), Space.World);
				}
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
		#endregion // 함수
	}
}
#endif // #if EXTRA_SCRIPT_MODULE_ENABLE
