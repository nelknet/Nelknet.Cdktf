using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerModel.SagemakerModelPrimaryContainerModelDataSource")]
    public class SagemakerModelPrimaryContainerModelDataSource : aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSource
    {
        private object _s3DataSource;

        /// <summary>s3_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#s3_data_source SagemakerModel#s3_data_source}
        /// </remarks>
        [JsiiProperty(name: "s3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerModelDataSourceS3DataSource\"},\"kind\":\"array\"}}]}}")]
        public object S3DataSource
        {
            get => _s3DataSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSourceS3DataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSourceS3DataSource).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSourceS3DataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3DataSource = value;
            }
        }
    }
}
