using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDomainSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDomainSettings")]
    public interface ISagemakerDomainDomainSettings
    {
        /// <summary>docker_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#docker_settings SagemakerDomain#docker_settings}
        /// </remarks>
        [JsiiProperty(name: "dockerSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsDockerSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDomainSettingsDockerSettings? DockerSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#execution_role_identity_config SagemakerDomain#execution_role_identity_config}.</summary>
        [JsiiProperty(name: "executionRoleIdentityConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExecutionRoleIdentityConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>r_studio_server_pro_domain_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#r_studio_server_pro_domain_settings SagemakerDomain#r_studio_server_pro_domain_settings}
        /// </remarks>
        [JsiiProperty(name: "rStudioServerProDomainSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettings? RStudioServerProDomainSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#security_group_ids SagemakerDomain#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDomainSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDomainSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDomainSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>docker_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#docker_settings SagemakerDomain#docker_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dockerSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsDockerSettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDomainSettingsDockerSettings? DockerSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDomainSettingsDockerSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#execution_role_identity_config SagemakerDomain#execution_role_identity_config}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executionRoleIdentityConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecutionRoleIdentityConfig
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>r_studio_server_pro_domain_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#r_studio_server_pro_domain_settings SagemakerDomain#r_studio_server_pro_domain_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rStudioServerProDomainSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettings? RStudioServerProDomainSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#security_group_ids SagemakerDomain#security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
