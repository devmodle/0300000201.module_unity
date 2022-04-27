using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if EXTRA_SCRIPT_ENABLE
namespace Google {
	/** 파이어 베이스 씬 관리자 */
	public partial class CGFirebaseSceneManager : StudyScene.CStudySceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_G_FIREBASE;
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
		#endregion			// 함수
	}
}
#endif			// #if EXTRA_SCRIPT_ENABLE
