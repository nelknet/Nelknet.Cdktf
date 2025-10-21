using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetails")]
    public class SagemakerProjectServiceCatalogProvisioningDetails : aws.SagemakerProject.ISagemakerProjectServiceCatalogProvisioningDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#product_id SagemakerProject#product_id}.</summary>
        [JsiiProperty(name: "productId", typeJson: "{\"primitive\":\"string\"}")]
        public string ProductId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#path_id SagemakerProject#path_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pathId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PathId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#provisioning_artifact_id SagemakerProject#provisioning_artifact_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "provisioningArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProvisioningArtifactId
        {
            get;
            set;
        }

        private object? _provisioningParameter;

        /// <summary>provisioning_parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#provisioning_parameter SagemakerProject#provisioning_parameter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioningParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ProvisioningParameter
        {
            get => _provisioningParameter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerProject.ISagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerProject.ISagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _provisioningParameter = value;
            }
        }
    }
}
