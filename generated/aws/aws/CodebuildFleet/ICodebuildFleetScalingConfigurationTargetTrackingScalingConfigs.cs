using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildFleet
{
    [JsiiInterface(nativeType: typeof(ICodebuildFleetScalingConfigurationTargetTrackingScalingConfigs), fullyQualifiedName: "aws.codebuildFleet.CodebuildFleetScalingConfigurationTargetTrackingScalingConfigs")]
    public interface ICodebuildFleetScalingConfigurationTargetTrackingScalingConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#metric_type CodebuildFleet#metric_type}.</summary>
        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#target_value CodebuildFleet#target_value}.</summary>
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildFleetScalingConfigurationTargetTrackingScalingConfigs), fullyQualifiedName: "aws.codebuildFleet.CodebuildFleetScalingConfigurationTargetTrackingScalingConfigs")]
        internal sealed class _Proxy : DeputyBase, aws.CodebuildFleet.ICodebuildFleetScalingConfigurationTargetTrackingScalingConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#metric_type CodebuildFleet#metric_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#target_value CodebuildFleet#target_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetValue
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
