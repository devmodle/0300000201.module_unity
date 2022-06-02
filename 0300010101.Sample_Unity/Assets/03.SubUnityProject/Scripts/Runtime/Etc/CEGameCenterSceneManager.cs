using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Etc {
	/** 게임 센터 씬 관리자 */
	public class CEGameCenterSceneManager : StudyScene.CStudySceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_E_GAME_CENTER;
		#endregion			// 프로퍼티
	}
}
#endif			// #if EXTRA_SCRIPT_MODULE_ENABLE
