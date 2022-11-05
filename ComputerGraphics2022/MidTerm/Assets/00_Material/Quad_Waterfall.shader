Shader "My/Quad_Waterfall"
{
    Properties
    {
        _MainTex("Albedo (RGB)", 2D) = "white" {}
        _MainTex2 ("Albedo (RGB)", 2D) = "white" {}
    }
        SubShader
    {
        Tags { "RenderType" = "Transparent" "Queue" = "Transparent"}

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows alpha:fade

        sampler2D _MainTex;
        sampler2D _MainTex2;

        struct Input
        {
            float2 uv_MainTex;
            float2 uv_MainTex2;
        };

        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
            fixed4 d = tex2D(_MainTex2, float2(IN.uv_MainTex.x, IN.uv_MainTex.y + _Time.z));
            o.Emission = c.rgb + d.rgb;
            o.Alpha = c.a * d.a;
        }
        ENDCG
    }
        FallBack "Diffuse"
}
