using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettings")]
    public interface ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettings
    {
        /// <summary>default_ebs_storage_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_ebs_storage_settings SagemakerDomain#default_ebs_storage_settings}
        /// </remarks>
        [JsiiProperty(name: "defaultEbsStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings? DefaultEbsStorageSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_ebs_storage_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_ebs_storage_settings SagemakerDomain#default_ebs_storage_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultEbsStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings? DefaultEbsStorageSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings?>();
            }
        }
    }
}
