using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Etc {
	/** 쉐이더 씬 관리자 */
	public partial class CEShaderSceneManager : StudyScene.CSSceneManager {
		#region 변수
		[SerializeField] private List<GameObject> m_oObjList = new List<GameObject>();
		#endregion            // 변수

		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_E_SHADER;
		#endregion           // 프로퍼티                 

		#region 함수
		/** 상태를 갱신한다 */
		public override void OnUpdate(float a_fDeltaTime) {
			base.OnUpdate(a_fDeltaTime);

			// 앱이 실행 중 일 경우
			if(CSceneManager.IsAppRunning) {
				for(int i = 0; i < m_oObjList.Count; ++i) {
					m_oObjList[i].transform.Rotate(Vector3.up, 90.0f * a_fDeltaTime, Space.World);
				}
			}
		}
		#endregion         // 함수
	}
}
#endif         // #if EXTRA_SCRIPT_MODULE_ENABLE                                           
