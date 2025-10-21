using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData")]
    public class AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData : aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#object_path AppflowFlow#object_path}.</summary>
        [JsiiProperty(name: "objectPath", typeJson: "{\"primitive\":\"string\"}")]
        public string ObjectPath
        {
            get;
            set;
        }

        /// <summary>pagination_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#pagination_config AppflowFlow#pagination_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paginationConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig? PaginationConfig
        {
            get;
            set;
        }

        /// <summary>parallelism_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#parallelism_config AppflowFlow#parallelism_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parallelismConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig? ParallelismConfig
        {
            get;
            set;
        }
    }
}
