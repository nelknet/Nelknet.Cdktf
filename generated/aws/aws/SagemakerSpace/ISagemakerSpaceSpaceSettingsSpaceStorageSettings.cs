using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiInterface(nativeType: typeof(ISagemakerSpaceSpaceSettingsSpaceStorageSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettings")]
    public interface ISagemakerSpaceSpaceSettingsSpaceStorageSettings
    {
        /// <summary>ebs_storage_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#ebs_storage_settings SagemakerSpace#ebs_storage_settings}
        /// </remarks>
        [JsiiProperty(name: "ebsStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings\"}")]
        aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings EbsStorageSettings
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerSpaceSpaceSettingsSpaceStorageSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ebs_storage_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#ebs_storage_settings SagemakerSpace#ebs_storage_settings}
            /// </remarks>
            [JsiiProperty(name: "ebsStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings\"}")]
            public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings EbsStorageSettings
            {
                get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings>()!;
            }
        }
    }
}
