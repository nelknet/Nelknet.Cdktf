using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskServerlessCluster
{
    [JsiiInterface(nativeType: typeof(IMskServerlessClusterClientAuthenticationSasl), fullyQualifiedName: "aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSasl")]
    public interface IMskServerlessClusterClientAuthenticationSasl
    {
        /// <summary>iam block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#iam MskServerlessCluster#iam}
        /// </remarks>
        [JsiiProperty(name: "iam", typeJson: "{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSaslIam\"}")]
        aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSaslIam Iam
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskServerlessClusterClientAuthenticationSasl), fullyQualifiedName: "aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSasl")]
        internal sealed class _Proxy : DeputyBase, aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSasl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>iam block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#iam MskServerlessCluster#iam}
            /// </remarks>
            [JsiiProperty(name: "iam", typeJson: "{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSaslIam\"}")]
            public aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSaslIam Iam
            {
                get => GetInstanceProperty<aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSaslIam>()!;
            }
        }
    }
}
