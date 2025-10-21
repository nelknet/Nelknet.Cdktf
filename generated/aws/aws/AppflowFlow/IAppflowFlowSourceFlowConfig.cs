using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowSourceFlowConfig), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfig")]
    public interface IAppflowFlowSourceFlowConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#connector_type AppflowFlow#connector_type}.</summary>
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectorType
        {
            get;
        }

        /// <summary>source_connector_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#source_connector_properties AppflowFlow#source_connector_properties}
        /// </remarks>
        [JsiiProperty(name: "sourceConnectorProperties", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorProperties\"}")]
        aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorProperties SourceConnectorProperties
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

        /// <summary>incremental_pull_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#incremental_pull_config AppflowFlow#incremental_pull_config}
        /// </remarks>
        [JsiiProperty(name: "incrementalPullConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigIncrementalPullConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppflowFlow.IAppflowFlowSourceFlowConfigIncrementalPullConfig? IncrementalPullConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowSourceFlowConfig), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowSourceFlowConfig
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

            /// <summary>source_connector_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#source_connector_properties AppflowFlow#source_connector_properties}
            /// </remarks>
            [JsiiProperty(name: "sourceConnectorProperties", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorProperties\"}")]
            public aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorProperties SourceConnectorProperties
            {
                get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorProperties>()!;
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

            /// <summary>incremental_pull_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#incremental_pull_config AppflowFlow#incremental_pull_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "incrementalPullConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigIncrementalPullConfig\"}", isOptional: true)]
            public aws.AppflowFlow.IAppflowFlowSourceFlowConfigIncrementalPullConfig? IncrementalPullConfig
            {
                get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigIncrementalPullConfig?>();
            }
        }
    }
}
