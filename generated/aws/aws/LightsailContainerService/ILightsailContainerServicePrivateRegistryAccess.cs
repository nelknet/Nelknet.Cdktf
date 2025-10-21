using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailContainerService
{
    [JsiiInterface(nativeType: typeof(ILightsailContainerServicePrivateRegistryAccess), fullyQualifiedName: "aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccess")]
    public interface ILightsailContainerServicePrivateRegistryAccess
    {
        /// <summary>ecr_image_puller_role block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#ecr_image_puller_role LightsailContainerService#ecr_image_puller_role}
        /// </remarks>
        [JsiiProperty(name: "ecrImagePullerRole", typeJson: "{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccessEcrImagePullerRole\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccessEcrImagePullerRole? EcrImagePullerRole
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailContainerServicePrivateRegistryAccess), fullyQualifiedName: "aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccess")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ecr_image_puller_role block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#ecr_image_puller_role LightsailContainerService#ecr_image_puller_role}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecrImagePullerRole", typeJson: "{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccessEcrImagePullerRole\"}", isOptional: true)]
            public aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccessEcrImagePullerRole? EcrImagePullerRole
            {
                get => GetInstanceProperty<aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccessEcrImagePullerRole?>();
            }
        }
    }
}
