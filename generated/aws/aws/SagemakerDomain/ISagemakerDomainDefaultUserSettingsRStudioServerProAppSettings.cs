using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultUserSettingsRStudioServerProAppSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsRStudioServerProAppSettings")]
    public interface ISagemakerDomainDefaultUserSettingsRStudioServerProAppSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#access_status SagemakerDomain#access_status}.</summary>
        [JsiiProperty(name: "accessStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#user_group SagemakerDomain#user_group}.</summary>
        [JsiiProperty(name: "userGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultUserSettingsRStudioServerProAppSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsRStudioServerProAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsRStudioServerProAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#access_status SagemakerDomain#access_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#user_group SagemakerDomain#user_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserGroup
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
