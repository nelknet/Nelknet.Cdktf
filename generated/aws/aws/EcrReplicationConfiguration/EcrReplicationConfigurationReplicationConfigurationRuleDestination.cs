using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrReplicationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRuleDestination")]
    public class EcrReplicationConfigurationReplicationConfigurationRuleDestination : aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfigurationRuleDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#region EcrReplicationConfiguration#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#registry_id EcrReplicationConfiguration#registry_id}.</summary>
        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}")]
        public string RegistryId
        {
            get;
            set;
        }
    }
}
