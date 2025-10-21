using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowDestinationFlowConfig), fullyQualifiedName: "aws.appflowFlow.AppflowFlowDestinationFlowConfig")]
    public interface IAppflowFlowDestinationFlowConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#connector_type AppflowFlow#connector_type}.</summary>
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectorType
        {
            get;
        }

        /// <summary>destination_connector_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#destination_connector_properties AppflowFlow#destination_connector_properties}
        /// </remarks>
        [JsiiProperty(name: "destinationConnectorProperties", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorProperties\"}")]
        aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorProperties DestinationConnectorProperties
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#api_version AppflowFlow#api_version}.</summary>
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#connector_profile_name AppflowFlow#connector_profile_name}.</summary>
        [JsiiProperty(name: "connectorProfileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectorProfileName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowDestinationFlowConfig), fullyQualifiedName: "aws.appflowFlow.AppflowFlowDestinationFlowConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowDestinationFlowConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#connector_type AppflowFlow#connector_type}.</summary>
            [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectorType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>destination_connector_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#destination_connector_properties AppflowFlow#destination_connector_properties}
            /// </remarks>
            [JsiiProperty(name: "destinationConnectorProperties", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorProperties\"}")]
            public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorProperties DestinationConnectorProperties
            {
                get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorProperties>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#api_version AppflowFlow#api_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#connector_profile_name AppflowFlow#connector_profile_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectorProfileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectorProfileName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
