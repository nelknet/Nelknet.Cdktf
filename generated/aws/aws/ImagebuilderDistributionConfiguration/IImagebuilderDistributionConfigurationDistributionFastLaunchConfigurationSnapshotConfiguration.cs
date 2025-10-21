using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderDistributionConfiguration
{
    [JsiiInterface(nativeType: typeof(IImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationSnapshotConfiguration), fullyQualifiedName: "aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationSnapshotConfiguration")]
    public interface IImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationSnapshotConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#target_resource_count ImagebuilderDistributionConfiguration#target_resource_count}.</summary>
        [JsiiProperty(name: "targetResourceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetResourceCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationSnapshotConfiguration), fullyQualifiedName: "aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationSnapshotConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationSnapshotConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#target_resource_count ImagebuilderDistributionConfiguration#target_resource_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetResourceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetResourceCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
