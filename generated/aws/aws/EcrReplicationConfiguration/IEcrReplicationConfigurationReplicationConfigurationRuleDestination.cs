using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrReplicationConfiguration
{
    [JsiiInterface(nativeType: typeof(IEcrReplicationConfigurationReplicationConfigurationRuleDestination), fullyQualifiedName: "aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRuleDestination")]
    public interface IEcrReplicationConfigurationReplicationConfigurationRuleDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#region EcrReplicationConfiguration#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#registry_id EcrReplicationConfiguration#registry_id}.</summary>
        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}")]
        string RegistryId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrReplicationConfigurationReplicationConfigurationRuleDestination), fullyQualifiedName: "aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRuleDestination")]
        internal sealed class _Proxy : DeputyBase, aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfigurationRuleDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#region EcrReplicationConfiguration#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#registry_id EcrReplicationConfiguration#registry_id}.</summary>
            [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}")]
            public string RegistryId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
