using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OamLink
{
    [JsiiByValue(fqn: "aws.oamLink.OamLinkLinkConfiguration")]
    public class OamLinkLinkConfiguration : aws.OamLink.IOamLinkLinkConfiguration
    {
        /// <summary>log_group_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#log_group_configuration OamLink#log_group_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logGroupConfiguration", typeJson: "{\"fqn\":\"aws.oamLink.OamLinkLinkConfigurationLogGroupConfiguration\"}", isOptional: true)]
        public aws.OamLink.IOamLinkLinkConfigurationLogGroupConfiguration? LogGroupConfiguration
        {
            get;
            set;
        }

        /// <summary>metric_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#metric_configuration OamLink#metric_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricConfiguration", typeJson: "{\"fqn\":\"aws.oamLink.OamLinkLinkConfigurationMetricConfiguration\"}", isOptional: true)]
        public aws.OamLink.IOamLinkLinkConfigurationMetricConfiguration? MetricConfiguration
        {
            get;
            set;
        }
    }
}
