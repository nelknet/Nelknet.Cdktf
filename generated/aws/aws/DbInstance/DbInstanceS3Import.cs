using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dbInstance.DbInstanceS3Import")]
    public class DbInstanceS3Import : aws.DbInstance.IDbInstanceS3Import
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#bucket_name DbInstance#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#ingestion_role DbInstance#ingestion_role}.</summary>
        [JsiiProperty(name: "ingestionRole", typeJson: "{\"primitive\":\"string\"}")]
        public string IngestionRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#source_engine DbInstance#source_engine}.</summary>
        [JsiiProperty(name: "sourceEngine", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceEngine
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#source_engine_version DbInstance#source_engine_version}.</summary>
        [JsiiProperty(name: "sourceEngineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceEngineVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#bucket_prefix DbInstance#bucket_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketPrefix
        {
            get;
            set;
        }
    }
}
