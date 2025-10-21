using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelContainerModelDataSource), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerModelDataSource")]
    public interface ISagemakerModelContainerModelDataSource
    {
        /// <summary>s3_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#s3_data_source SagemakerModel#s3_data_source}
        /// </remarks>
        [JsiiProperty(name: "s3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerModelDataSourceS3DataSource\"},\"kind\":\"array\"}}]}}")]
        object S3DataSource
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelContainerModelDataSource), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerModelDataSource")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerModel.ISagemakerModelContainerModelDataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#s3_data_source SagemakerModel#s3_data_source}
            /// </remarks>
            [JsiiProperty(name: "s3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerModelDataSourceS3DataSource\"},\"kind\":\"array\"}}]}}")]
            public object S3DataSource
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
