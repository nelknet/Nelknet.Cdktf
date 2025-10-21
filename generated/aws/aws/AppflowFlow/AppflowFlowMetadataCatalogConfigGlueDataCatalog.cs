using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowMetadataCatalogConfigGlueDataCatalog")]
    public class AppflowFlowMetadataCatalogConfigGlueDataCatalog : aws.AppflowFlow.IAppflowFlowMetadataCatalogConfigGlueDataCatalog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#database_name AppflowFlow#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#role_arn AppflowFlow#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#table_prefix AppflowFlow#table_prefix}.</summary>
        [JsiiProperty(name: "tablePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string TablePrefix
        {
            get;
            set;
        }
    }
}
