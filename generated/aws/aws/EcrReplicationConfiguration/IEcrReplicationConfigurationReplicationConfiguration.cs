using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrReplicationConfiguration
{
    [JsiiInterface(nativeType: typeof(IEcrReplicationConfigurationReplicationConfiguration), fullyQualifiedName: "aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfiguration")]
    public interface IEcrReplicationConfigurationReplicationConfiguration
    {
        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#rule EcrReplicationConfiguration#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRule\"},\"kind\":\"array\"}}]}}")]
        object Rule
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrReplicationConfigurationReplicationConfiguration), fullyQualifiedName: "aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#rule EcrReplicationConfiguration#rule}
            /// </remarks>
            [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRule\"},\"kind\":\"array\"}}]}}")]
            public object Rule
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
