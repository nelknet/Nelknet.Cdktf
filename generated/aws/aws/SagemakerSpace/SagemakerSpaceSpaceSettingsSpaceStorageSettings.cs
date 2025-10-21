using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettings")]
    public class SagemakerSpaceSpaceSettingsSpaceStorageSettings : aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettings
    {
        /// <summary>ebs_storage_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#ebs_storage_settings SagemakerSpace#ebs_storage_settings}
        /// </remarks>
        [JsiiProperty(name: "ebsStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings\"}")]
        public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings EbsStorageSettings
        {
            get;
            set;
        }
    }
}
