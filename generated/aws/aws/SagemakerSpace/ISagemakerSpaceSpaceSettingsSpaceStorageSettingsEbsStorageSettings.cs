using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiInterface(nativeType: typeof(ISagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings")]
    public interface ISagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#ebs_volume_size_in_gb SagemakerSpace#ebs_volume_size_in_gb}.</summary>
        [JsiiProperty(name: "ebsVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        double EbsVolumeSizeInGb
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#ebs_volume_size_in_gb SagemakerSpace#ebs_volume_size_in_gb}.</summary>
            [JsiiProperty(name: "ebsVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
            public double EbsVolumeSizeInGb
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
