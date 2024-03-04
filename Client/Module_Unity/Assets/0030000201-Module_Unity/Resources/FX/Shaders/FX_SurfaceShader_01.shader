Shader "FX/FX_SurfaceShader_01" {
	Properties {
		_Color("Color", Color) = (1, 1, 1, 1)
		_MainTex("Main Texture", 2D) = "white" { }
		_NormalTex("Normal Texture", 2D) = "bump" { }
	}
	SubShader {
		Tags {
			"Queue" = "Geometry+1"
			"RenderType" = "Opaque"
		}

		CGPROGRAM
		#pragma target 3.0
		#pragma surface SSMain Custom

		float4 _Color;

		sampler2D _MainTex;
		sampler2D _NormalTex;

		/** 입력 */
		struct Input {
			float4 color;
			float2 uv_MainTex;
			float2 uv_NormalTex;
		};

		/** 출력 */
		struct SurfaceOutputCustom {
			float Gloss;
			float Alpha;
			float Specular;

			float3 Albedo;
			float3 Normal;
			float3 Emission;
		};

		/** 서피스 쉐이더 */
		void SSMain(Input a_stInput, inout SurfaceOutputCustom a_stOutput) {
			float4 stAlbedo = tex2D(_MainTex, a_stInput.uv_MainTex);

			a_stOutput.Alpha = stAlbedo.a;
			a_stOutput.Albedo = stAlbedo.rgb;
			a_stOutput.Normal = UnpackNormal(tex2D(_NormalTex, a_stInput.uv_NormalTex));
		}

		/** 색상을 반환한다 */
		float4 LightingCustom(SurfaceOutputCustom a_stOutput, float3 a_stLightDirection, float3 a_stViewDirection, float a_fAttenuation) {
			float fDiffuse = saturate(dot(a_stOutput.Normal, a_stLightDirection));
			float3 stFinalColor = a_stOutput.Albedo * fDiffuse;

			return float4(stFinalColor * a_fAttenuation, a_stOutput.Alpha) * _Color;
		}
		ENDCG
	}
}
