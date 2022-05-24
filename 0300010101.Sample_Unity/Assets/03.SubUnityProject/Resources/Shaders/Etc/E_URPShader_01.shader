Shader "Etc/E_URPShader_01" {
	Properties {
		[MainColor] _Color("Color", Color) = (1.0, 1.0, 1.0, 1.0)
		[MainTexture] _MainTexture("MainTexture", 2D) = "white" { }
	}

	SubShader {
		Tags {
			"RenderType" = "Opaque" "RenderQueue" = "Geometry+1" "RenderPipeline" = "UniversalPipeline"
		}

		Pass {
			HLSLPROGRAM
			#pragma vertex VSMain
			#pragma fragment PSMain

			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

			CBUFFER_START(UnityPerMaterial)
			float4 _Color;
			CBUFFER_END

			/** 입력 */
			struct STInput {
				float3 m_stPos: POSITION;
				float3 m_stNormal: NORMAL;
			};

			/** 출력 */
			struct STOutput {
				float4 m_stPos: SV_POSITION;
				float3 m_stWorldPos: TEXCOORD0;
				float3 m_stWorldNormal: TEXCOORD1;
				float3 m_stWorldLightDir: TEXCOORD2;
			};

			/** 정점 쉐이더 */
			STOutput VSMain(STInput a_stInput) {
				STOutput stOutput = (STOutput)0;
				float3 stWorldPos = TransformObjectToWorld(a_stInput.m_stPos);

				stOutput.m_stPos = TransformObjectToHClip(a_stInput.m_stPos);
				stOutput.m_stWorldPos = stWorldPos;
				stOutput.m_stWorldNormal = TransformObjectToWorldNormal(a_stInput.m_stNormal);
				stOutput.m_stWorldLightDir = _MainLightPosition.xyz;

				return stOutput;
			}

			/** 픽셀 쉐이더 */
			float4 PSMain(STOutput a_stOutput) : SV_TARGET {
				float3 stWorldNormal = normalize(a_stOutput.m_stWorldNormal);
				float3 stWorldLightDir = normalize(a_stOutput.m_stWorldLightDir);

				return float4(_MainLightColor.rgb * saturate(dot(stWorldLightDir, stWorldNormal)), 1.0) * _Color;
			}
			ENDHLSL
		}
	}
}
