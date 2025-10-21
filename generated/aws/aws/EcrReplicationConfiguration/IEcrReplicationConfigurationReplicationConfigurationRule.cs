using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrReplicationConfiguration
{
    [JsiiInterface(nativeType: typeof(IEcrReplicationConfigurationReplicationConfigurationRule), fullyQualifiedName: "aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRule")]
    public interface IEcrReplicationConfigurationReplicationConfigurationRule
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#destination EcrReplicationConfiguration#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRuleDestination\"},\"kind\":\"array\"}}]}}")]
        object Destination
        {
            get;
        }

        /// <summary>repository_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#repository_filter EcrReplicationConfiguration#repository_filter}
        /// </remarks>
        [JsiiProperty(name: "repositoryFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RepositoryFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrReplicationConfigurationReplicationConfigurationRule), fullyQualifiedName: "aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#destination EcrReplicationConfiguration#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRuleDestination\"},\"kind\":\"array\"}}]}}")]
            public object Destination
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>repository_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#repository_filter EcrReplicationConfiguration#repository_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RepositoryFilter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
