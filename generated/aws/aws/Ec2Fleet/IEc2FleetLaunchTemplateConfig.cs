using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    [JsiiInterface(nativeType: typeof(IEc2FleetLaunchTemplateConfig), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetLaunchTemplateConfig")]
    public interface IEc2FleetLaunchTemplateConfig
    {
        /// <summary>launch_template_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#launch_template_specification Ec2Fleet#launch_template_specification}
        /// </remarks>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification? LaunchTemplateSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#override Ec2Fleet#override}
        /// </remarks>
        [JsiiProperty(name: "override", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Override
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetLaunchTemplateConfig), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetLaunchTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2Fleet.IEc2FleetLaunchTemplateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>launch_template_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#launch_template_specification Ec2Fleet#launch_template_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification\"}", isOptional: true)]
            public aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification? LaunchTemplateSpecification
            {
                get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification?>();
            }

            /// <summary>override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#override Ec2Fleet#override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "override", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Override
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
