using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDomainSettingsDockerSettings")]
    public class SagemakerDomainDomainSettingsDockerSettings : aws.SagemakerDomain.ISagemakerDomainDomainSettingsDockerSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#enable_docker_access SagemakerDomain#enable_docker_access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableDockerAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EnableDockerAccess
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#vpc_only_trusted_accounts SagemakerDomain#vpc_only_trusted_accounts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcOnlyTrustedAccounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VpcOnlyTrustedAccounts
        {
            get;
            set;
        }
    }
}
