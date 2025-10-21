using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowMetadataCatalogConfigGlueDataCatalog), fullyQualifiedName: "aws.appflowFlow.AppflowFlowMetadataCatalogConfigGlueDataCatalog")]
    public interface IAppflowFlowMetadataCatalogConfigGlueDataCatalog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#database_name AppflowFlow#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#role_arn AppflowFlow#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#table_prefix AppflowFlow#table_prefix}.</summary>
        [JsiiProperty(name: "tablePrefix", typeJson: "{\"primitive\":\"string\"}")]
        string TablePrefix
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowMetadataCatalogConfigGlueDataCatalog), fullyQualifiedName: "aws.appflowFlow.AppflowFlowMetadataCatalogConfigGlueDataCatalog")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowMetadataCatalogConfigGlueDataCatalog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#database_name AppflowFlow#database_name}.</summary>
            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#role_arn AppflowFlow#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#table_prefix AppflowFlow#table_prefix}.</summary>
            [JsiiProperty(name: "tablePrefix", typeJson: "{\"primitive\":\"string\"}")]
            public string TablePrefix
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
