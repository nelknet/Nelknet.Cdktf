using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateNetworkInterfacesEnaSrdSpecification), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecification")]
    public interface ILaunchTemplateNetworkInterfacesEnaSrdSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#ena_srd_enabled LaunchTemplate#ena_srd_enabled}.</summary>
        [JsiiProperty(name: "enaSrdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnaSrdEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>ena_srd_udp_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#ena_srd_udp_specification LaunchTemplate#ena_srd_udp_specification}
        /// </remarks>
        [JsiiProperty(name: "enaSrdUdpSpecification", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification? EnaSrdUdpSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateNetworkInterfacesEnaSrdSpecification), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesEnaSrdSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#ena_srd_enabled LaunchTemplate#ena_srd_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enaSrdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnaSrdEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ena_srd_udp_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#ena_srd_udp_specification LaunchTemplate#ena_srd_udp_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enaSrdUdpSpecification", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification\"}", isOptional: true)]
            public aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification? EnaSrdUdpSpecification
            {
                get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification?>();
            }
        }
    }
}
