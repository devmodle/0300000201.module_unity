using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Etc {
	/** 효과 씬 관리자 */
	public class CEFXSceneManager : StudyScene.CStudySceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_E_FX;
		#endregion			// 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {

			}
		}
		#endregion			// 함수
	}
}