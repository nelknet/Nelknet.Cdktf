using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDomainSettingsRStudioServerProDomainSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettings")]
    public interface ISagemakerDomainDomainSettingsRStudioServerProDomainSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#domain_execution_role_arn SagemakerDomain#domain_execution_role_arn}.</summary>
        [JsiiProperty(name: "domainExecutionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string DomainExecutionRoleArn
        {
            get;
        }

        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec? DefaultResourceSpec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#r_studio_connect_url SagemakerDomain#r_studio_connect_url}.</summary>
        [JsiiProperty(name: "rStudioConnectUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RStudioConnectUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#r_studio_package_manager_url SagemakerDomain#r_studio_package_manager_url}.</summary>
        [JsiiProperty(name: "rStudioPackageManagerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RStudioPackageManagerUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDomainSettingsRStudioServerProDomainSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#domain_execution_role_arn SagemakerDomain#domain_execution_role_arn}.</summary>
            [JsiiProperty(name: "domainExecutionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainExecutionRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>default_resource_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec? DefaultResourceSpec
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#r_studio_connect_url SagemakerDomain#r_studio_connect_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rStudioConnectUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RStudioConnectUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#r_studio_package_manager_url SagemakerDomain#r_studio_package_manager_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rStudioPackageManagerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RStudioPackageManagerUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
