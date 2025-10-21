using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RdsCluster
{
    [JsiiInterface(nativeType: typeof(IRdsClusterRestoreToPointInTime), fullyQualifiedName: "aws.rdsCluster.RdsClusterRestoreToPointInTime")]
    public interface IRdsClusterRestoreToPointInTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#restore_to_time RdsCluster#restore_to_time}.</summary>
        [JsiiProperty(name: "restoreToTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RestoreToTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#restore_type RdsCluster#restore_type}.</summary>
        [JsiiProperty(name: "restoreType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RestoreType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#source_cluster_identifier RdsCluster#source_cluster_identifier}.</summary>
        [JsiiProperty(name: "sourceClusterIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceClusterIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#source_cluster_resource_id RdsCluster#source_cluster_resource_id}.</summary>
        [JsiiProperty(name: "sourceClusterResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceClusterResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#use_latest_restorable_time RdsCluster#use_latest_restorable_time}.</summary>
        [JsiiProperty(name: "useLatestRestorableTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseLatestRestorableTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRdsClusterRestoreToPointInTime), fullyQualifiedName: "aws.rdsCluster.RdsClusterRestoreToPointInTime")]
        internal sealed class _Proxy : DeputyBase, aws.RdsCluster.IRdsClusterRestoreToPointInTime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#restore_to_time RdsCluster#restore_to_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restoreToTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RestoreToTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#restore_type RdsCluster#restore_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restoreType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RestoreType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#source_cluster_identifier RdsCluster#source_cluster_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceClusterIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceClusterIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#source_cluster_resource_id RdsCluster#source_cluster_resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceClusterResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceClusterResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#use_latest_restorable_time RdsCluster#use_latest_restorable_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useLatestRestorableTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseLatestRestorableTime
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
