using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig")]
    public interface IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#max_page_size AppflowFlow#max_page_size}.</summary>
        [JsiiProperty(name: "maxPageSize", typeJson: "{\"primitive\":\"number\"}")]
        double MaxPageSize
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#max_page_size AppflowFlow#max_page_size}.</summary>
            [JsiiProperty(name: "maxPageSize", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxPageSize
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
