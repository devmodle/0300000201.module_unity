using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Etc {
	/** 파티클 씬 관리자 */
	public class CEParticleSceneManager : StudyScene.CSSceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_E_PARTICLE;
		#endregion			// 프로퍼티
	}
}
#endif			// #if EXTRA_SCRIPT_MODULE_ENABLE
