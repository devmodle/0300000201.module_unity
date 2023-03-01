using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace FX {
	/** 파티클 씬 관리자 */
	public class CFXParticleSceneManager : StudyScene.CSSceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_FX_PARTICLE;
		#endregion // 프로퍼티
	}
}
#endif // #if EXTRA_SCRIPT_MODULE_ENABLE
