using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsTensorBoardAppSettings")]
    public interface ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpec
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsTensorBoardAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_resource_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpec
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec?>();
            }
        }
    }
}
