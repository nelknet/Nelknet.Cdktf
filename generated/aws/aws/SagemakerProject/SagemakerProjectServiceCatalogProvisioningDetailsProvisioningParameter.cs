using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter")]
    public class SagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter : aws.SagemakerProject.ISagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#key SagemakerProject#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#value SagemakerProject#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
