using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterEncryptionInfoEncryptionInTransit), fullyQualifiedName: "aws.mskCluster.MskClusterEncryptionInfoEncryptionInTransit")]
    public interface IMskClusterEncryptionInfoEncryptionInTransit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#client_broker MskCluster#client_broker}.</summary>
        [JsiiProperty(name: "clientBroker", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientBroker
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#in_cluster MskCluster#in_cluster}.</summary>
        [JsiiProperty(name: "inCluster", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InCluster
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterEncryptionInfoEncryptionInTransit), fullyQualifiedName: "aws.mskCluster.MskClusterEncryptionInfoEncryptionInTransit")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterEncryptionInfoEncryptionInTransit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#client_broker MskCluster#client_broker}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientBroker", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientBroker
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#in_cluster MskCluster#in_cluster}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inCluster", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? InCluster
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
