using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig")]
    public interface IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#max_page_size AppflowFlow#max_page_size}.</summary>
        [JsiiProperty(name: "maxPageSize", typeJson: "{\"primitive\":\"number\"}")]
        double MaxPageSize
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig
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
