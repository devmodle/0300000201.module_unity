Shader "Etc/UniversalRenderPipeline/E_URPShader_01" {
	Properties {
		[MainColor] _Color("Color", Color) = (1.0, 1.0, 1.0, 1.0)
		[MainTexture] _MainTexture("MainTexture", 2D) = "white" { }
	} SubShader {
		Tags {
			"Queue" = "Geometry+1"
			"RenderType" = "Opaque"
			"RenderPipeline" = "UniversalPipeline"
		} Pass {
			HLSLPROGRAM
			#pragma vertex VSMain
			#pragma fragment PSMain
			
			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

			CBUFFER_START(UnityPerMaterial)
			float4 _Color;
			float4 _MainTexture_ST;
			CBUFFER_END

			TEXTURE2D(_MainTexture);
			SAMPLER(sampler_MainTexture);

			/** 입력 */
			struct STInput {
				float3 m_stPos: POSITION;
				float3 m_stNormal: NORMAL;
				float2 m_stUV: TEXCOORD0;
			};

			/** 출력 */
			struct STOutput {
				float4 m_stPos: SV_POSITION;
				float3 m_stNormal: NORMAL;
				float2 m_stUV: TEXCOORD0;
				float3 m_stLightDir: TEXCOORD1;
			};

			/** 정점 쉐이더 */
			STOutput VSMain(STInput a_stInput) {
				STOutput stOutput = (STOutput)0;
				stOutput.m_stPos = TransformObjectToHClip(a_stInput.m_stPos);
				stOutput.m_stNormal = TransformObjectToWorldNormal(a_stInput.m_stNormal);
				stOutput.m_stUV = TRANSFORM_TEX(a_stInput.m_stUV, _MainTexture);
				stOutput.m_stLightDir = _MainLightPosition.xyz;

				return stOutput;
			}

			/** 픽셀 쉐이더 */
			float4 PSMain(STOutput a_stInput) : SV_TARGET {
				float3 stNormal = normalize(a_stInput.m_stNormal);
				float3 stLightDir = normalize(a_stInput.m_stLightDir);
				float4 stDiffuseColor = SAMPLE_TEXTURE2D(_MainTexture, sampler_MainTexture, a_stInput.m_stUV);

				float3 stLightColor = (_MainLightColor.rgb * saturate(dot(stNormal, stLightDir))) + SampleSH(stNormal);
				return float4((stLightColor * stDiffuseColor.rgb) * _Color.rgb, stDiffuseColor.a * _Color.a);
			}
			ENDHLSL
		}
	}
}
