using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Firebase
{
	/** 데이터 베이스 씬 관리자 */
	public partial class CFDBSceneManager : StudyScene.CSSceneManager
	{
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_F_DB;
		#endregion         // 프로퍼티                 
	}
}
#endif         // #if EXTRA_SCRIPT_MODULE_ENABLE                                           
