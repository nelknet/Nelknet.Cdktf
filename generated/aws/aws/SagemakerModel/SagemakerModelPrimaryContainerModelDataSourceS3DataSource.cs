using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerModel.SagemakerModelPrimaryContainerModelDataSourceS3DataSource")]
    public class SagemakerModelPrimaryContainerModelDataSourceS3DataSource : aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSourceS3DataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#compression_type SagemakerModel#compression_type}.</summary>
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}")]
        public string CompressionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#s3_data_type SagemakerModel#s3_data_type}.</summary>
        [JsiiProperty(name: "s3DataType", typeJson: "{\"primitive\":\"string\"}")]
        public string S3DataType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#s3_uri SagemakerModel#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Uri
        {
            get;
            set;
        }

        /// <summary>model_access_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#model_access_config SagemakerModel#model_access_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelAccessConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig\"}", isOptional: true)]
        public aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig
        {
            get;
            set;
        }
    }
}
