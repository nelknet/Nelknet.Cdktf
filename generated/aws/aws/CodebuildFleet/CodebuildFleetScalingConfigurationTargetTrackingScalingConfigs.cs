using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildFleet
{
    [JsiiByValue(fqn: "aws.codebuildFleet.CodebuildFleetScalingConfigurationTargetTrackingScalingConfigs")]
    public class CodebuildFleetScalingConfigurationTargetTrackingScalingConfigs : aws.CodebuildFleet.ICodebuildFleetScalingConfigurationTargetTrackingScalingConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#metric_type CodebuildFleet#metric_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#target_value CodebuildFleet#target_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetValue
        {
            get;
            set;
        }
    }
}
