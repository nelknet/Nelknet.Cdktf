using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailContainerService
{
    [JsiiByValue(fqn: "aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccess")]
    public class LightsailContainerServicePrivateRegistryAccess : aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccess
    {
        /// <summary>ecr_image_puller_role block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#ecr_image_puller_role LightsailContainerService#ecr_image_puller_role}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecrImagePullerRole", typeJson: "{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccessEcrImagePullerRole\"}", isOptional: true)]
        public aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccessEcrImagePullerRole? EcrImagePullerRole
        {
            get;
            set;
        }
    }
}
