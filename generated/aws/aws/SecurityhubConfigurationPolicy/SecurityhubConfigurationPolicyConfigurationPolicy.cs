using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubConfigurationPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubConfigurationPolicy.SecurityhubConfigurationPolicyConfigurationPolicy")]
    public class SecurityhubConfigurationPolicyConfigurationPolicy : aws.SecurityhubConfigurationPolicy.ISecurityhubConfigurationPolicyConfigurationPolicy
    {
        private object _serviceEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_configuration_policy#service_enabled SecurityhubConfigurationPolicy#service_enabled}.</summary>
        [JsiiProperty(name: "serviceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object ServiceEnabled
        {
            get => _serviceEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serviceEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_configuration_policy#enabled_standard_arns SecurityhubConfigurationPolicy#enabled_standard_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabledStandardArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EnabledStandardArns
        {
            get;
            set;
        }

        /// <summary>security_controls_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_configuration_policy#security_controls_configuration SecurityhubConfigurationPolicy#security_controls_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "securityControlsConfiguration", typeJson: "{\"fqn\":\"aws.securityhubConfigurationPolicy.SecurityhubConfigurationPolicyConfigurationPolicySecurityControlsConfiguration\"}", isOptional: true)]
        public aws.SecurityhubConfigurationPolicy.ISecurityhubConfigurationPolicyConfigurationPolicySecurityControlsConfiguration? SecurityControlsConfiguration
        {
            get;
            set;
        }
    }
}
