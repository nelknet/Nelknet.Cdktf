using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData")]
    public interface IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#object_path AppflowFlow#object_path}.</summary>
        [JsiiProperty(name: "objectPath", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectPath
        {
            get;
        }

        /// <summary>pagination_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#pagination_config AppflowFlow#pagination_config}
        /// </remarks>
        [JsiiProperty(name: "paginationConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig? PaginationConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>parallelism_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#parallelism_config AppflowFlow#parallelism_config}
        /// </remarks>
        [JsiiProperty(name: "parallelismConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig? ParallelismConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData
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

            /// <summary>pagination_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#pagination_config AppflowFlow#pagination_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paginationConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig\"}", isOptional: true)]
            public aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig? PaginationConfig
            {
                get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig?>();
            }

            /// <summary>parallelism_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#parallelism_config AppflowFlow#parallelism_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parallelismConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig\"}", isOptional: true)]
            public aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig? ParallelismConfig
            {
                get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig?>();
            }
        }
    }
}
