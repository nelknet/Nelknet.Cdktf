using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerApp
{
    [JsiiByValue(fqn: "aws.sagemakerApp.SagemakerAppResourceSpec")]
    public class SagemakerAppResourceSpec : aws.SagemakerApp.ISagemakerAppResourceSpec
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#instance_type SagemakerApp#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#lifecycle_config_arn SagemakerApp#lifecycle_config_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycleConfigArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LifecycleConfigArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#sagemaker_image_arn SagemakerApp#sagemaker_image_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sagemakerImageArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SagemakerImageArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#sagemaker_image_version_alias SagemakerApp#sagemaker_image_version_alias}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sagemakerImageVersionAlias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SagemakerImageVersionAlias
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#sagemaker_image_version_arn SagemakerApp#sagemaker_image_version_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sagemakerImageVersionArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SagemakerImageVersionArn
        {
            get;
            set;
        }
    }
}
