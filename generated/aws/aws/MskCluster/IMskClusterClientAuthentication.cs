using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterClientAuthentication), fullyQualifiedName: "aws.mskCluster.MskClusterClientAuthentication")]
    public interface IMskClusterClientAuthentication
    {
        /// <summary>sasl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#sasl MskCluster#sasl}
        /// </remarks>
        [JsiiProperty(name: "sasl", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterClientAuthenticationSasl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterClientAuthenticationSasl? Sasl
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#tls MskCluster#tls}
        /// </remarks>
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterClientAuthenticationTls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterClientAuthenticationTls? Tls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#unauthenticated MskCluster#unauthenticated}.</summary>
        [JsiiProperty(name: "unauthenticated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Unauthenticated
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterClientAuthentication), fullyQualifiedName: "aws.mskCluster.MskClusterClientAuthentication")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterClientAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>sasl block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#sasl MskCluster#sasl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sasl", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterClientAuthenticationSasl\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterClientAuthenticationSasl? Sasl
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterClientAuthenticationSasl?>();
            }

            /// <summary>tls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#tls MskCluster#tls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterClientAuthenticationTls\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterClientAuthenticationTls? Tls
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterClientAuthenticationTls?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#unauthenticated MskCluster#unauthenticated}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unauthenticated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Unauthenticated
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
