using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsService.EcsServiceVolumeConfiguration")]
    public class EcsServiceVolumeConfiguration : aws.EcsService.IEcsServiceVolumeConfiguration
    {
        /// <summary>managed_ebs_volume block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#managed_ebs_volume EcsService#managed_ebs_volume}
        /// </remarks>
        [JsiiProperty(name: "managedEbsVolume", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceVolumeConfigurationManagedEbsVolume\"}")]
        public aws.EcsService.IEcsServiceVolumeConfigurationManagedEbsVolume ManagedEbsVolume
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#name EcsService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
