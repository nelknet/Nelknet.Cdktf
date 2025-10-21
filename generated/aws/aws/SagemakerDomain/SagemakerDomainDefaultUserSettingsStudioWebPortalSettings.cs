using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsStudioWebPortalSettings")]
    public class SagemakerDomainDefaultUserSettingsStudioWebPortalSettings : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsStudioWebPortalSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#hidden_app_types SagemakerDomain#hidden_app_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hiddenAppTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HiddenAppTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#hidden_instance_types SagemakerDomain#hidden_instance_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hiddenInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HiddenInstanceTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#hidden_ml_tools SagemakerDomain#hidden_ml_tools}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hiddenMlTools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HiddenMlTools
        {
            get;
            set;
        }
    }
}
