using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigRemediationConfiguration
{
    [JsiiByValue(fqn: "aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControlsSsmControls")]
    public class ConfigRemediationConfigurationExecutionControlsSsmControls : aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControlsSsmControls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#concurrent_execution_rate_percentage ConfigRemediationConfiguration#concurrent_execution_rate_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "concurrentExecutionRatePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConcurrentExecutionRatePercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#error_percentage ConfigRemediationConfiguration#error_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ErrorPercentage
        {
            get;
            set;
        }
    }
}
