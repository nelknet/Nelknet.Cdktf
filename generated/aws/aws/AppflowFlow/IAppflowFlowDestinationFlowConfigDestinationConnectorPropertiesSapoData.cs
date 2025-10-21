using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoData), fullyQualifiedName: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoData")]
    public interface IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#object_path AppflowFlow#object_path}.</summary>
        [JsiiProperty(name: "objectPath", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectPath
        {
            get;
        }

        /// <summary>error_handling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#error_handling_config AppflowFlow#error_handling_config}
        /// </remarks>
        [JsiiProperty(name: "errorHandlingConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig? ErrorHandlingConfig
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

        /// <summary>success_response_handling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#success_response_handling_config AppflowFlow#success_response_handling_config}
        /// </remarks>
        [JsiiProperty(name: "successResponseHandlingConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig? SuccessResponseHandlingConfig
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

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoData), fullyQualifiedName: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoData")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#object_path AppflowFlow#object_path}.</summary>
            [JsiiProperty(name: "objectPath", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>error_handling_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#error_handling_config AppflowFlow#error_handling_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "errorHandlingConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig\"}", isOptional: true)]
            public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig? ErrorHandlingConfig
            {
                get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#id_field_names AppflowFlow#id_field_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idFieldNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IdFieldNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>success_response_handling_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#success_response_handling_config AppflowFlow#success_response_handling_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "successResponseHandlingConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig\"}", isOptional: true)]
            public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig? SuccessResponseHandlingConfig
            {
                get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig?>();
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
