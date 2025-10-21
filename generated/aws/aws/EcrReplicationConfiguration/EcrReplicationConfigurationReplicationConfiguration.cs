using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrReplicationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfiguration")]
    public class EcrReplicationConfigurationReplicationConfiguration : aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfiguration
    {
        private object _rule;

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_replication_configuration#rule EcrReplicationConfiguration#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecrReplicationConfiguration.EcrReplicationConfigurationReplicationConfigurationRule\"},\"kind\":\"array\"}}]}}")]
        public object Rule
        {
            get => _rule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfigurationRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfigurationRule).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcrReplicationConfiguration.IEcrReplicationConfigurationReplicationConfigurationRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rule = value;
            }
        }
    }
}
