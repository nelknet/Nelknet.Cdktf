using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OamLink
{
    [JsiiInterface(nativeType: typeof(IOamLinkLinkConfiguration), fullyQualifiedName: "aws.oamLink.OamLinkLinkConfiguration")]
    public interface IOamLinkLinkConfiguration
    {
        /// <summary>log_group_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#log_group_configuration OamLink#log_group_configuration}
        /// </remarks>
        [JsiiProperty(name: "logGroupConfiguration", typeJson: "{\"fqn\":\"aws.oamLink.OamLinkLinkConfigurationLogGroupConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OamLink.IOamLinkLinkConfigurationLogGroupConfiguration? LogGroupConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>metric_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#metric_configuration OamLink#metric_configuration}
        /// </remarks>
        [JsiiProperty(name: "metricConfiguration", typeJson: "{\"fqn\":\"aws.oamLink.OamLinkLinkConfigurationMetricConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OamLink.IOamLinkLinkConfigurationMetricConfiguration? MetricConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOamLinkLinkConfiguration), fullyQualifiedName: "aws.oamLink.OamLinkLinkConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.OamLink.IOamLinkLinkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>log_group_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#log_group_configuration OamLink#log_group_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logGroupConfiguration", typeJson: "{\"fqn\":\"aws.oamLink.OamLinkLinkConfigurationLogGroupConfiguration\"}", isOptional: true)]
            public aws.OamLink.IOamLinkLinkConfigurationLogGroupConfiguration? LogGroupConfiguration
            {
                get => GetInstanceProperty<aws.OamLink.IOamLinkLinkConfigurationLogGroupConfiguration?>();
            }

            /// <summary>metric_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#metric_configuration OamLink#metric_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metricConfiguration", typeJson: "{\"fqn\":\"aws.oamLink.OamLinkLinkConfigurationMetricConfiguration\"}", isOptional: true)]
            public aws.OamLink.IOamLinkLinkConfigurationMetricConfiguration? MetricConfiguration
            {
                get => GetInstanceProperty<aws.OamLink.IOamLinkLinkConfigurationMetricConfiguration?>();
            }
        }
    }
}
