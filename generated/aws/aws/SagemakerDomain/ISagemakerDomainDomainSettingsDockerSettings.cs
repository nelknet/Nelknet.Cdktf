using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDomainSettingsDockerSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDomainSettingsDockerSettings")]
    public interface ISagemakerDomainDomainSettingsDockerSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#enable_docker_access SagemakerDomain#enable_docker_access}.</summary>
        [JsiiProperty(name: "enableDockerAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EnableDockerAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#vpc_only_trusted_accounts SagemakerDomain#vpc_only_trusted_accounts}.</summary>
        [JsiiProperty(name: "vpcOnlyTrustedAccounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpcOnlyTrustedAccounts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDomainSettingsDockerSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDomainSettingsDockerSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDomainSettingsDockerSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#enable_docker_access SagemakerDomain#enable_docker_access}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableDockerAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EnableDockerAccess
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#vpc_only_trusted_accounts SagemakerDomain#vpc_only_trusted_accounts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcOnlyTrustedAccounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcOnlyTrustedAccounts
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
