using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderDistributionConfiguration
{
    [JsiiByValue(fqn: "aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationSnapshotConfiguration")]
    public class ImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationSnapshotConfiguration : aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationSnapshotConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#target_resource_count ImagebuilderDistributionConfiguration#target_resource_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetResourceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetResourceCount
        {
            get;
            set;
        }
    }
}
