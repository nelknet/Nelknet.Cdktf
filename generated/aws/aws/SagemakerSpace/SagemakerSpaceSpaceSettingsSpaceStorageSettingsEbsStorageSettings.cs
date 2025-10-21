using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings")]
    public class SagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings : aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#ebs_volume_size_in_gb SagemakerSpace#ebs_volume_size_in_gb}.</summary>
        [JsiiProperty(name: "ebsVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double EbsVolumeSizeInGb
        {
            get;
            set;
        }
    }
}
