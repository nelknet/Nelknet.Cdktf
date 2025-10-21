using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigRemediationConfiguration
{
    [JsiiInterface(nativeType: typeof(IConfigRemediationConfigurationExecutionControls), fullyQualifiedName: "aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControls")]
    public interface IConfigRemediationConfigurationExecutionControls
    {
        /// <summary>ssm_controls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#ssm_controls ConfigRemediationConfiguration#ssm_controls}
        /// </remarks>
        [JsiiProperty(name: "ssmControls", typeJson: "{\"fqn\":\"aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControlsSsmControls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControlsSsmControls? SsmControls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigRemediationConfigurationExecutionControls), fullyQualifiedName: "aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControls")]
        internal sealed class _Proxy : DeputyBase, aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ssm_controls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#ssm_controls ConfigRemediationConfiguration#ssm_controls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssmControls", typeJson: "{\"fqn\":\"aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControlsSsmControls\"}", isOptional: true)]
            public aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControlsSsmControls? SsmControls
            {
                get => GetInstanceProperty<aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControlsSsmControls?>();
            }
        }
    }
}
