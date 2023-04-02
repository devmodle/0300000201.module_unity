using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
/** 추가 상수 */
public static partial class KDefine {
	#region 기본
	// 씬 이름 {
	public const string G_SCENE_N_ADS_ADMOB = "01-Ads_AdmobScene";
	public const string G_SCENE_N_ADS_IRON_SRC = "02-Ads_IronSrcScene";
	public const string G_SCENE_N_ADS_APP_LOVIN = "03-Ads_AppLovinScene";

	public const string G_SCENE_N_FX_SHADER = "01-FX_ShaderScene";
	public const string G_SCENE_N_FX_PARTICLE = "02-FX_ParticleScene";
	// 씬 이름 }
	#endregion // 기본

	#region 런타임 상수

	#endregion // 런타임 상수
}

namespace NSEngine {
	/** 엔진 추가 상수 */
	public static partial class KDefine {
		#region 기본

		#endregion // 기본

		#region 런타임 상수

		#endregion // 런타임 상수
	}
}
#endif // #if EXTRA_SCRIPT_MODULE_ENABLE
