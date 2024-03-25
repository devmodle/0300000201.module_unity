using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
using System.Diagnostics;

#if NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
#endif // #if NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE

namespace Etc
{
	/** 직렬화 씬 관리자 */
	public partial class CEtcSerializationSceneManager : ResearchScene.CRSceneManager
	{
		/** 식별자 */
		private enum EKey
		{
			NONE = -1,
			[HideInInspector] MAX_VAL
		}

		#region 변수
		private Stopwatch m_oStopwatch = new Stopwatch();
		#endregion // 변수

		#region 프로퍼티

		#endregion // 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake()
		{
			base.Awake();

			// 앱이 초기화되었을 경우
			if(CSceneManager.IsInitApp)
			{
				// 버튼을 설정한다
				CFunc.SetupButtons(new List<(string, GameObject, UnityAction)>() {
					("SIMPLE_JSON_BTN", this.UIs, this.OnTouchSimpleJSONBtn),
					("NEWTONSOFT_JSON_BTN", this.UIs, this.OnTouchNewtonsoftJSONBtn)
				});
			}
		}

		/** 초기화 */
		public override void Start()
		{
			base.Start();

			// 앱이 초기화되었을 경우
			if(CSceneManager.IsInitApp)
			{
				this.UpdateUIsState();
			}
		}

		/** 제거되었을 경우 */
		public override void OnDestroy()
		{
			base.OnDestroy();

			try
			{
				// 앱이 실행 중 일 경우
				if(CSceneManager.IsRunningApp)
				{
					// Do Something
				}
			}
			catch(System.Exception oException)
			{
				CFunc.ShowLogWarning($"CEtcSerializationSceneManager.OnDestroy Exception: {oException.Message}");
			}
		}

		/** 상태를 갱신한다 */
		public override void OnUpdate(float a_fDeltaTime)
		{
			base.OnUpdate(a_fDeltaTime);

			// 앱이 실행 중 일 경우
			if(CSceneManager.IsRunningApp)
			{
				// Do Something
			}
		}

		/** 내비게이션 스택 이벤트를 수신했을 경우 */
		public override void OnReceiveEventNavStack(EEventNavStack a_eEvent)
		{
			base.OnReceiveEventNavStack(a_eEvent);

			// 백 키 눌림 이벤트 일 경우
			if(a_eEvent == EEventNavStack.BACK_KEY_DOWN)
			{
				// Do Something
			}
		}

		/** UI 상태를 갱신한다 */
		private void UpdateUIsState()
		{
			// Do Something
		}

		/** Simple JSON 버튼을 눌렀을 경우 */
		private void OnTouchSimpleJSONBtn()
		{
			var oJSONStr = CFunc.ReadStr(Access.EtcInfoTableLoadPath, false);
			m_oStopwatch.Restart();

			var oJSONNode = SimpleJSON.JSON.Parse(oJSONStr).AsObject;

			foreach(var stKeyVal in oJSONNode)
			{
				var stKeyValPair = (KeyValuePair<string, SimpleJSON.JSONNode>)stKeyVal;

				for(int i = 0; i < stKeyValPair.Value.Count; ++i)
				{
					CFunc.ShowLog($"{stKeyValPair.Value[i]}");
				}
			}

			CFunc.ShowLog($"CEtcSerializationSceneManager.OnTouchSimpleJSONBtn: {m_oStopwatch.ElapsedMilliseconds} ms");
		}

		/** Newtonsoft JSON 버튼을 눌렀을 경우 */
		private void OnTouchNewtonsoftJSONBtn()
		{
#if NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE
			var oJSONStr = CFunc.ReadStr(Access.EtcInfoTableLoadPath, false);
			m_oStopwatch.Restart();

			var oJSONObject = JObject.Parse(oJSONStr);

			foreach(var stKeyVal in oJSONObject)
			{
				var oJSONDatas = (JArray)stKeyVal.Value;

				for(int i = 0; i < oJSONDatas.Count; ++i)
				{
					CFunc.ShowLog($"{oJSONDatas[i]}");
				}
			}

			CFunc.ShowLog($"CEtcSerializationSceneManager.OnTouchNewtonsoftJSONBtn: {m_oStopwatch.ElapsedMilliseconds} ms");
#endif // #if NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE
		}
		#endregion // 함수
	}
}
#endif // #if EXTRA_SCRIPT_MODULE_ENABLE
