using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigRemediationConfiguration
{
    [JsiiInterface(nativeType: typeof(IConfigRemediationConfigurationExecutionControlsSsmControls), fullyQualifiedName: "aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControlsSsmControls")]
    public interface IConfigRemediationConfigurationExecutionControlsSsmControls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#concurrent_execution_rate_percentage ConfigRemediationConfiguration#concurrent_execution_rate_percentage}.</summary>
        [JsiiProperty(name: "concurrentExecutionRatePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConcurrentExecutionRatePercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#error_percentage ConfigRemediationConfiguration#error_percentage}.</summary>
        [JsiiProperty(name: "errorPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ErrorPercentage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigRemediationConfigurationExecutionControlsSsmControls), fullyQualifiedName: "aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControlsSsmControls")]
        internal sealed class _Proxy : DeputyBase, aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControlsSsmControls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#concurrent_execution_rate_percentage ConfigRemediationConfiguration#concurrent_execution_rate_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "concurrentExecutionRatePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConcurrentExecutionRatePercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#error_percentage ConfigRemediationConfiguration#error_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "errorPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ErrorPercentage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
