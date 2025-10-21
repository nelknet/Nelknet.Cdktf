using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotFleetRequest
{
    [JsiiInterface(nativeType: typeof(ISpotFleetRequestLaunchTemplateConfig), fullyQualifiedName: "aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfig")]
    public interface ISpotFleetRequestLaunchTemplateConfig
    {
        /// <summary>launch_template_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#launch_template_specification SpotFleetRequest#launch_template_specification}
        /// </remarks>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification\"}")]
        aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification LaunchTemplateSpecification
        {
            get;
        }

        /// <summary>overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#overrides SpotFleetRequest#overrides}
        /// </remarks>
        [JsiiProperty(name: "overrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Overrides
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotFleetRequestLaunchTemplateConfig), fullyQualifiedName: "aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>launch_template_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#launch_template_specification SpotFleetRequest#launch_template_specification}
            /// </remarks>
            [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification\"}")]
            public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification LaunchTemplateSpecification
            {
                get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification>()!;
            }

            /// <summary>overrides block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#overrides SpotFleetRequest#overrides}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Overrides
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
