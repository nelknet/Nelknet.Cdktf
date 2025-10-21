using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrRegistryScanningConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecrRegistryScanningConfiguration.EcrRegistryScanningConfigurationRule")]
    public class EcrRegistryScanningConfigurationRule : aws.EcrRegistryScanningConfiguration.IEcrRegistryScanningConfigurationRule
    {
        private object _repositoryFilter;

        /// <summary>repository_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_registry_scanning_configuration#repository_filter EcrRegistryScanningConfiguration#repository_filter}
        /// </remarks>
        [JsiiProperty(name: "repositoryFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecrRegistryScanningConfiguration.EcrRegistryScanningConfigurationRuleRepositoryFilter\"},\"kind\":\"array\"}}]}}")]
        public object RepositoryFilter
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
                        case aws.EcrRegistryScanningConfiguration.IEcrRegistryScanningConfigurationRuleRepositoryFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcrRegistryScanningConfiguration.IEcrRegistryScanningConfigurationRuleRepositoryFilter).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcrRegistryScanningConfiguration.IEcrRegistryScanningConfigurationRuleRepositoryFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _repositoryFilter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_registry_scanning_configuration#scan_frequency EcrRegistryScanningConfiguration#scan_frequency}.</summary>
        [JsiiProperty(name: "scanFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public string ScanFrequency
        {
            get;
            set;
        }
    }
}
