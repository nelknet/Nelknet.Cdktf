using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrReplicationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRule")]
    public class EcrReplicationConfigurationReplicationConfigurationRule : aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfigurationRule
    {
        private object _destination;

        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#destination EcrReplicationConfiguration#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRuleDestination\"},\"kind\":\"array\"}}]}}")]
        public object Destination
        {
            get => _destination;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfigurationRuleDestination[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfigurationRuleDestination).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfigurationRuleDestination).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _destination = value;
            }
        }

        private object? _repositoryFilter;

        /// <summary>repository_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#repository_filter EcrReplicationConfiguration#repository_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RepositoryFilter
        {
            get => _repositoryFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _repositoryFilter = value;
            }
        }
    }
}
