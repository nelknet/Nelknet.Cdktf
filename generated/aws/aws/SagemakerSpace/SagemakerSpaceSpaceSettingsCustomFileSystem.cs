using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystem")]
    public class SagemakerSpaceSpaceSettingsCustomFileSystem : aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystem
    {
        /// <summary>efs_file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#efs_file_system SagemakerSpace#efs_file_system}
        /// </remarks>
        [JsiiProperty(name: "efsFileSystem", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystem\"}")]
        public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystem EfsFileSystem
        {
            get;
            set;
        }
    }
}
