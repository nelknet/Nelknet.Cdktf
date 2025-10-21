using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DocdbCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.docdbCluster.DocdbClusterRestoreToPointInTime")]
    public class DocdbClusterRestoreToPointInTime : aws.DocdbCluster.IDocdbClusterRestoreToPointInTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#source_cluster_identifier DocdbCluster#source_cluster_identifier}.</summary>
        [JsiiProperty(name: "sourceClusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceClusterIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#restore_to_time DocdbCluster#restore_to_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "restoreToTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RestoreToTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#restore_type DocdbCluster#restore_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "restoreType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RestoreType
        {
            get;
            set;
        }

        private object? _useLatestRestorableTime;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#use_latest_restorable_time DocdbCluster#use_latest_restorable_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useLatestRestorableTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseLatestRestorableTime
        {
            get => _useLatestRestorableTime;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _useLatestRestorableTime = value;
            }
        }
    }
}
