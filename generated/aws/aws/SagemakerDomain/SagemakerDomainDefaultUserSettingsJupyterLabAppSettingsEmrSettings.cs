using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsEmrSettings")]
    public class SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsEmrSettings : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsEmrSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#assumable_role_arns SagemakerDomain#assumable_role_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "assumableRoleArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AssumableRoleArns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#execution_role_arns SagemakerDomain#execution_role_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExecutionRoleArns
        {
            get;
            set;
        }
    }
}
