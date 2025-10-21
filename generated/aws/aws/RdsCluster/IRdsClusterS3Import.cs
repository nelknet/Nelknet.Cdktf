using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RdsCluster
{
    [JsiiInterface(nativeType: typeof(IRdsClusterS3Import), fullyQualifiedName: "aws.rdsCluster.RdsClusterS3Import")]
    public interface IRdsClusterS3Import
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#bucket_name RdsCluster#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        string BucketName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#ingestion_role RdsCluster#ingestion_role}.</summary>
        [JsiiProperty(name: "ingestionRole", typeJson: "{\"primitive\":\"string\"}")]
        string IngestionRole
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#source_engine RdsCluster#source_engine}.</summary>
        [JsiiProperty(name: "sourceEngine", typeJson: "{\"primitive\":\"string\"}")]
        string SourceEngine
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#source_engine_version RdsCluster#source_engine_version}.</summary>
        [JsiiProperty(name: "sourceEngineVersion", typeJson: "{\"primitive\":\"string\"}")]
        string SourceEngineVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#bucket_prefix RdsCluster#bucket_prefix}.</summary>
        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRdsClusterS3Import), fullyQualifiedName: "aws.rdsCluster.RdsClusterS3Import")]
        internal sealed class _Proxy : DeputyBase, aws.RdsCluster.IRdsClusterS3Import
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#bucket_name RdsCluster#bucket_name}.</summary>
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#ingestion_role RdsCluster#ingestion_role}.</summary>
            [JsiiProperty(name: "ingestionRole", typeJson: "{\"primitive\":\"string\"}")]
            public string IngestionRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#source_engine RdsCluster#source_engine}.</summary>
            [JsiiProperty(name: "sourceEngine", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceEngine
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#source_engine_version RdsCluster#source_engine_version}.</summary>
            [JsiiProperty(name: "sourceEngineVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceEngineVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#bucket_prefix RdsCluster#bucket_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
