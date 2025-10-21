using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskServerlessCluster
{
    [JsiiInterface(nativeType: typeof(IMskServerlessClusterClientAuthentication), fullyQualifiedName: "aws.mskServerlessCluster.MskServerlessClusterClientAuthentication")]
    public interface IMskServerlessClusterClientAuthentication
    {
        /// <summary>sasl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#sasl MskServerlessCluster#sasl}
        /// </remarks>
        [JsiiProperty(name: "sasl", typeJson: "{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSasl\"}")]
        aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSasl Sasl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskServerlessClusterClientAuthentication), fullyQualifiedName: "aws.mskServerlessCluster.MskServerlessClusterClientAuthentication")]
        internal sealed class _Proxy : DeputyBase, aws.MskServerlessCluster.IMskServerlessClusterClientAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>sasl block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#sasl MskServerlessCluster#sasl}
            /// </remarks>
            [JsiiProperty(name: "sasl", typeJson: "{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSasl\"}")]
            public aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSasl Sasl
            {
                get => GetInstanceProperty<aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSasl>()!;
            }
        }
    }
}
