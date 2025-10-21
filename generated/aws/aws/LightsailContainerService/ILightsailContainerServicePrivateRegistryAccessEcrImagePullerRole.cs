using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailContainerService
{
    [JsiiInterface(nativeType: typeof(ILightsailContainerServicePrivateRegistryAccessEcrImagePullerRole), fullyQualifiedName: "aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccessEcrImagePullerRole")]
    public interface ILightsailContainerServicePrivateRegistryAccessEcrImagePullerRole
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#is_active LightsailContainerService#is_active}.</summary>
        [JsiiProperty(name: "isActive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsActive
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailContainerServicePrivateRegistryAccessEcrImagePullerRole), fullyQualifiedName: "aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccessEcrImagePullerRole")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccessEcrImagePullerRole
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#is_active LightsailContainerService#is_active}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isActive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IsActive
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
