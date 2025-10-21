using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadog), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadog")]
    public interface IAppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#object AppflowFlow#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        string Object
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadog), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadog")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#object AppflowFlow#object}.</summary>
            [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
            public string Object
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
