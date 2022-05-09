Shader "Shaders/G_URPShader_01" {
	Properties {
		_Color("Color", Color) = (1, 1, 1, 1)
		_MainTex("MainTexture", 2D) = "white" {}
	} SubShader {
		Tags {
			"RenderType" = "Opaque"
			"RenderQueue" = "Geometry+1"
		} Pass {
			HLSLPROGRAM
			#pragma vert VSMain
			#pragma frag PSMain

			/** 입력 */
			struct STInput {
				float3 m_stPos: POSITION;
				float2 m_stUV: TEXCOORD0;
			};

			/** 출력 */
			struct STOutput {
				float4 m_stPos: SV_POSITION;
				float2 m_stUV: TEXCOORD0;
			};

			/** 정점 쉐이더 */
			STOutput VSMain(STInput a_stInput) {
				STOutput stOutput = (STOutput)0;
				stOutput.m_stPos = TransformObjectToHClip(a_stInput.m_stPos);

				return stOutput;
			}

			/** 픽셀 쉐이더 */
			float4 PSMain(STOutput a_stInput) : SV_TARGET {
				return float4(1.0, 1.0, 1.0, 1.0);
			}
			ENDHLSL
		}
	}
}
