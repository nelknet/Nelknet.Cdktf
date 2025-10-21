using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskServerlessCluster
{
    [JsiiInterface(nativeType: typeof(IMskServerlessClusterClientAuthenticationSaslIam), fullyQualifiedName: "aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSaslIam")]
    public interface IMskServerlessClusterClientAuthenticationSaslIam
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#enabled MskServerlessCluster#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskServerlessClusterClientAuthenticationSaslIam), fullyQualifiedName: "aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSaslIam")]
        internal sealed class _Proxy : DeputyBase, aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSaslIam
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#enabled MskServerlessCluster#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
