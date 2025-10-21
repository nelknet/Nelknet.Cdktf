using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiInterface(nativeType: typeof(ISagemakerSpaceSpaceSettingsCustomFileSystem), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystem")]
    public interface ISagemakerSpaceSpaceSettingsCustomFileSystem
    {
        /// <summary>efs_file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#efs_file_system SagemakerSpace#efs_file_system}
        /// </remarks>
        [JsiiProperty(name: "efsFileSystem", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystem\"}")]
        aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystem EfsFileSystem
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerSpaceSpaceSettingsCustomFileSystem), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystem")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>efs_file_system block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#efs_file_system SagemakerSpace#efs_file_system}
            /// </remarks>
            [JsiiProperty(name: "efsFileSystem", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystem\"}")]
            public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystem EfsFileSystem
            {
                get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystem>()!;
            }
        }
    }
}
