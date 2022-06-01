using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Etc {
	/** 파티클 씬 관리자 */
	public class CEParticleSceneManager : StudyScene.CStudySceneManager {
		#region 변수
		/** =====> 객체 <===== */
		[SerializeField] private List<GameObject> m_oParticleList = new List<GameObject>();
		#endregion			// 변수

		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_E_PARTICLE;
		public override EProjection MainCameraProjection => EProjection._2D;
		#endregion			// 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
				// Do Something
			}
		}

		/** 상태를 갱신한다 */
		public override void OnUpdate(float a_fDeltaTime) {
			base.OnUpdate(a_fDeltaTime);

			// 앱이 실행 중 일 경우
			if(CSceneManager.IsAppRunning) {
				for(int i = 0; i < m_oParticleList.Count; ++i) {
					m_oParticleList[i].transform.Rotate(Vector3.forward, 90.0f * a_fDeltaTime, Space.World);
				}
			}
		}
		#endregion			// 함수
	}
}
#endif			// #if EXTRA_SCRIPT_MODULE_ENABLE
