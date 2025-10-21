using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification")]
    public interface ILaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#ena_srd_udp_enabled LaunchTemplate#ena_srd_udp_enabled}.</summary>
        [JsiiProperty(name: "enaSrdUdpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnaSrdUdpEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#ena_srd_udp_enabled LaunchTemplate#ena_srd_udp_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enaSrdUdpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnaSrdUdpEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
