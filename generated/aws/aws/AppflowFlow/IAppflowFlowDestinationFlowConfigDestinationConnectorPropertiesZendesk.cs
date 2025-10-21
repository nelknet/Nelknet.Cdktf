using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesZendesk), fullyQualifiedName: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesZendesk")]
    public interface IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesZendesk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#object AppflowFlow#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        string Object
        {
            get;
        }

        /// <summary>error_handling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#error_handling_config AppflowFlow#error_handling_config}
        /// </remarks>
        [JsiiProperty(name: "errorHandlingConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig? ErrorHandlingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#id_field_names AppflowFlow#id_field_names}.</summary>
        [JsiiProperty(name: "idFieldNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IdFieldNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#write_operation_type AppflowFlow#write_operation_type}.</summary>
        [JsiiProperty(name: "writeOperationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WriteOperationType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesZendesk), fullyQualifiedName: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesZendesk")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesZendesk
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

            /// <summary>error_handling_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#error_handling_config AppflowFlow#error_handling_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "errorHandlingConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig\"}", isOptional: true)]
            public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig? ErrorHandlingConfig
            {
                get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#id_field_names AppflowFlow#id_field_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idFieldNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IdFieldNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#write_operation_type AppflowFlow#write_operation_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "writeOperationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WriteOperationType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
