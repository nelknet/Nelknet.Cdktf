using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelContainerModelDataSourceS3DataSourceModelAccessConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerModelDataSourceS3DataSourceModelAccessConfig")]
    public interface ISagemakerModelContainerModelDataSourceS3DataSourceModelAccessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#accept_eula SagemakerModel#accept_eula}.</summary>
        [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object AcceptEula
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelContainerModelDataSourceS3DataSourceModelAccessConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerModelDataSourceS3DataSourceModelAccessConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerModel.ISagemakerModelContainerModelDataSourceS3DataSourceModelAccessConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#accept_eula SagemakerModel#accept_eula}.</summary>
            [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object AcceptEula
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
