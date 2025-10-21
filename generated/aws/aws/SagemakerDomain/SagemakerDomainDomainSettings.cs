using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDomainSettings")]
    public class SagemakerDomainDomainSettings : aws.SagemakerDomain.ISagemakerDomainDomainSettings
    {
        /// <summary>docker_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#docker_settings SagemakerDomain#docker_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dockerSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsDockerSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDomainSettingsDockerSettings? DockerSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#execution_role_identity_config SagemakerDomain#execution_role_identity_config}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionRoleIdentityConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExecutionRoleIdentityConfig
        {
            get;
            set;
        }

        /// <summary>r_studio_server_pro_domain_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#r_studio_server_pro_domain_settings SagemakerDomain#r_studio_server_pro_domain_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rStudioServerProDomainSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettings? RStudioServerProDomainSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#security_group_ids SagemakerDomain#security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupIds
        {
            get;
            set;
        }
    }
}
