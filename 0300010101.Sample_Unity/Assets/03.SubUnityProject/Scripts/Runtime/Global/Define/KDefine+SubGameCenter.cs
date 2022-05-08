using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if GAME_CENTER_MODULE_ENABLE && RUNTIME_TEMPLATES_MODULE_ENABLE
/** 게임 센터 상수 */
public static partial class KDefine {
	#region 기본
	// 식별자 {
#if UNITY_IOS
	public const string GC_LEADERBOARD_ID_SAMPLE = "dante.distribution.sample.gc.l.sample";
	public const string GC_ACHIEVEMENT_ID_SAMPLE = "dante.distribution.sample.gc.a.sample";
#else
	public const string GC_LEADERBOARD_ID_SAMPLE = GPGSIds.leaderboard_sample;
	public const string GC_ACHIEVEMENT_ID_SAMPLE = GPGSIds.achievement_sample;
#endif			// #if UNITY_IOS
	// 식별자 }
	#endregion			// 기본
}
#endif			// #if GAME_CENTER_MODULE_ENABLE && RUNTIME_TEMPLATES_MODULE_ENABLE
