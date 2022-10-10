Shader "My/Cube_Texture"
{
    Properties
    {
        //_Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        fixed4 _Color;

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex); // edit: *_Color;
            o.Albedo = (c.r + c.g + c.b) / 3; // gray scale // edit: c.rgb;
            //o.Albedo = 0.5;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
