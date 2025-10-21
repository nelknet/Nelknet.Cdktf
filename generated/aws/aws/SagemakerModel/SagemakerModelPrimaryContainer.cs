using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiByValue(fqn: "aws.sagemakerModel.SagemakerModelPrimaryContainer")]
    public class SagemakerModelPrimaryContainer : aws.SagemakerModel.ISagemakerModelPrimaryContainer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#container_hostname SagemakerModel#container_hostname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerHostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#environment SagemakerModel#environment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Environment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#image SagemakerModel#image}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Image
        {
            get;
            set;
        }

        /// <summary>image_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#image_config SagemakerModel#image_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imageConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfig\"}", isOptional: true)]
        public aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfig? ImageConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#inference_specification_name SagemakerModel#inference_specification_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceSpecificationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InferenceSpecificationName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#mode SagemakerModel#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>model_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#model_data_source SagemakerModel#model_data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelDataSource", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerModelDataSource\"}", isOptional: true)]
        public aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSource? ModelDataSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#model_data_url SagemakerModel#model_data_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelDataUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelDataUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#model_package_name SagemakerModel#model_package_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelPackageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelPackageName
        {
            get;
            set;
        }

        /// <summary>multi_model_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#multi_model_config SagemakerModel#multi_model_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "multiModelConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerMultiModelConfig\"}", isOptional: true)]
        public aws.SagemakerModel.ISagemakerModelPrimaryContainerMultiModelConfig? MultiModelConfig
        {
            get;
            set;
        }
    }
}
