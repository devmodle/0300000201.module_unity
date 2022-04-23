using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Google {
	/** 게임 센터 씬 관리자 */
	public partial class CGGameCenterSceneManager : StudyScene.CStudySceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_G_GAME_CENTER;
		#endregion			// 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
#if GAME_CENTER_MODULE_ENABLE

#endif			// #if GAME_CENTER_MODULE_ENABLE
			}
		}
		#endregion			// 함수
	}
}
