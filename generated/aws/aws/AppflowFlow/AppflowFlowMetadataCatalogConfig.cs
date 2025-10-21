using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowMetadataCatalogConfig")]
    public class AppflowFlowMetadataCatalogConfig : aws.AppflowFlow.IAppflowFlowMetadataCatalogConfig
    {
        /// <summary>glue_data_catalog block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#glue_data_catalog AppflowFlow#glue_data_catalog}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "glueDataCatalog", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowMetadataCatalogConfigGlueDataCatalog\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowMetadataCatalogConfigGlueDataCatalog? GlueDataCatalog
        {
            get;
            set;
        }
    }
}
