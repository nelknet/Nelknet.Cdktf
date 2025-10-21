using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowSourceFlowConfigIncrementalPullConfig), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigIncrementalPullConfig")]
    public interface IAppflowFlowSourceFlowConfigIncrementalPullConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#datetime_type_field_name AppflowFlow#datetime_type_field_name}.</summary>
        [JsiiProperty(name: "datetimeTypeFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatetimeTypeFieldName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowSourceFlowConfigIncrementalPullConfig), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigIncrementalPullConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowSourceFlowConfigIncrementalPullConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#datetime_type_field_name AppflowFlow#datetime_type_field_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "datetimeTypeFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatetimeTypeFieldName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
