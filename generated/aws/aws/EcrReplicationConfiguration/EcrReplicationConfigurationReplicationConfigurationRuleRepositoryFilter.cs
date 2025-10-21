using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrReplicationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter")]
    public class EcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter : aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#filter EcrReplicationConfiguration#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
        public string Filter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#filter_type EcrReplicationConfiguration#filter_type}.</summary>
        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}")]
        public string FilterType
        {
            get;
            set;
        }
    }
}
