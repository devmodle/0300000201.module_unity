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
	}
}
#endif			// #if EXTRA_SCRIPT_MODULE_ENABLE
