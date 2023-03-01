Shader "Global/G_URPShader_01" {
	Properties {
		_MainTex("Texture", 2D) = "white" {}
	}
	SubShader {
		Tags {
			"RenderType" = "Opaque"
		}
		Pass {
			CGPROGRAM
			#pragma vertex VSMain
			#pragma fragment PSMain

			#include "UnityCG.cginc"

			/** 입력 */
			struct STInput {
				float3 m_stPos: POSITION;
				float3 m_stNormal: NORMAL;
				float3 m_stTangent: TANGENT;
				float2 m_stUV: TEXCOORD0;
			};

			/** 출력 */
			struct STOutput {
				float4 m_stPos: SV_POSITION;
				float3 m_stNormal: NORMAL;
				float3 m_stTangent: TANGENT;
				float2 m_stUV: TEXCOORD0;
			};

			/** 정점 쉐이더 */
			STOutput VSMain(STInput a_stInput) {
				STOutput stOutput = (STOutput)0;
				float4 stWorldPos = mul(unity_ObjectToWorld, float4(a_stInput.m_stPos, 1.0f));

				stOutput.m_stPos = mul(UNITY_MATRIX_VP, stWorldPos);
				stOutput.m_stNormal = mul((float3x3)unity_ObjectToWorld, a_stInput.m_stNormal);
				stOutput.m_stTangent = mul((float3x3)unity_ObjectToWorld, a_stInput.m_stTangent);
				stOutput.m_stUV = a_stInput.m_stUV;

				return stOutput;
			}

			/** 픽셀 쉐이더 */
			float4 PSMain(STOutput a_stInput) : SV_TARGET {
				return float4(1.0f, 0.0f, 0.0f, 1.0f);
			}
			ENDCG
		}
	}
}
