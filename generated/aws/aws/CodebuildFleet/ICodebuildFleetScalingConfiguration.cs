using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildFleet
{
    [JsiiInterface(nativeType: typeof(ICodebuildFleetScalingConfiguration), fullyQualifiedName: "aws.codebuildFleet.CodebuildFleetScalingConfiguration")]
    public interface ICodebuildFleetScalingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#max_capacity CodebuildFleet#max_capacity}.</summary>
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#scaling_type CodebuildFleet#scaling_type}.</summary>
        [JsiiProperty(name: "scalingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScalingType
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_tracking_scaling_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#target_tracking_scaling_configs CodebuildFleet#target_tracking_scaling_configs}
        /// </remarks>
        [JsiiProperty(name: "targetTrackingScalingConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildFleet.CodebuildFleetScalingConfigurationTargetTrackingScalingConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TargetTrackingScalingConfigs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildFleetScalingConfiguration), fullyQualifiedName: "aws.codebuildFleet.CodebuildFleetScalingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CodebuildFleet.ICodebuildFleetScalingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#max_capacity CodebuildFleet#max_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#scaling_type CodebuildFleet#scaling_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scalingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScalingType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>target_tracking_scaling_configs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#target_tracking_scaling_configs CodebuildFleet#target_tracking_scaling_configs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetTrackingScalingConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildFleet.CodebuildFleetScalingConfigurationTargetTrackingScalingConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TargetTrackingScalingConfigs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
