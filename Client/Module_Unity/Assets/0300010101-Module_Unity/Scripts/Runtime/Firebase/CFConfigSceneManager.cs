using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Firebase {
	/** 구성 씬 관리자 */
	public partial class CFConfigSceneManager : StudyScene.CSSceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_F_CONFIG;
		#endregion // 프로퍼티
	}
}
#endif // #if EXTRA_SCRIPT_MODULE_ENABLE
