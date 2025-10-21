using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles), fullyQualifiedName: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles")]
    public interface IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#domain_name AppflowFlow#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#object_type_name AppflowFlow#object_type_name}.</summary>
        [JsiiProperty(name: "objectTypeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectTypeName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles), fullyQualifiedName: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#domain_name AppflowFlow#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#object_type_name AppflowFlow#object_type_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectTypeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectTypeName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
