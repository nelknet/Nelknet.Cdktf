using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigRemediationConfiguration
{
    [JsiiByValue(fqn: "aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControls")]
    public class ConfigRemediationConfigurationExecutionControls : aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControls
    {
        /// <summary>ssm_controls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#ssm_controls ConfigRemediationConfiguration#ssm_controls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ssmControls", typeJson: "{\"fqn\":\"aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControlsSsmControls\"}", isOptional: true)]
        public aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControlsSsmControls? SsmControls
        {
            get;
            set;
        }
    }
}
