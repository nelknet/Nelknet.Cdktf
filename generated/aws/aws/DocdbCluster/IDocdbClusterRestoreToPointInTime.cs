using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DocdbCluster
{
    [JsiiInterface(nativeType: typeof(IDocdbClusterRestoreToPointInTime), fullyQualifiedName: "aws.docdbCluster.DocdbClusterRestoreToPointInTime")]
    public interface IDocdbClusterRestoreToPointInTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#source_cluster_identifier DocdbCluster#source_cluster_identifier}.</summary>
        [JsiiProperty(name: "sourceClusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string SourceClusterIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#restore_to_time DocdbCluster#restore_to_time}.</summary>
        [JsiiProperty(name: "restoreToTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RestoreToTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#restore_type DocdbCluster#restore_type}.</summary>
        [JsiiProperty(name: "restoreType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RestoreType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#use_latest_restorable_time DocdbCluster#use_latest_restorable_time}.</summary>
        [JsiiProperty(name: "useLatestRestorableTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseLatestRestorableTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDocdbClusterRestoreToPointInTime), fullyQualifiedName: "aws.docdbCluster.DocdbClusterRestoreToPointInTime")]
        internal sealed class _Proxy : DeputyBase, aws.DocdbCluster.IDocdbClusterRestoreToPointInTime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#source_cluster_identifier DocdbCluster#source_cluster_identifier}.</summary>
            [JsiiProperty(name: "sourceClusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceClusterIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#restore_to_time DocdbCluster#restore_to_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restoreToTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RestoreToTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#restore_type DocdbCluster#restore_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restoreType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RestoreType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#use_latest_restorable_time DocdbCluster#use_latest_restorable_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useLatestRestorableTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseLatestRestorableTime
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
