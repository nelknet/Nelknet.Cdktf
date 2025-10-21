using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings")]
    public interface ISagemakerDomainDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_ebs_volume_size_in_gb SagemakerDomain#default_ebs_volume_size_in_gb}.</summary>
        [JsiiProperty(name: "defaultEbsVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        double DefaultEbsVolumeSizeInGb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#maximum_ebs_volume_size_in_gb SagemakerDomain#maximum_ebs_volume_size_in_gb}.</summary>
        [JsiiProperty(name: "maximumEbsVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        double MaximumEbsVolumeSizeInGb
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_ebs_volume_size_in_gb SagemakerDomain#default_ebs_volume_size_in_gb}.</summary>
            [JsiiProperty(name: "defaultEbsVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
            public double DefaultEbsVolumeSizeInGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#maximum_ebs_volume_size_in_gb SagemakerDomain#maximum_ebs_volume_size_in_gb}.</summary>
            [JsiiProperty(name: "maximumEbsVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
            public double MaximumEbsVolumeSizeInGb
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
