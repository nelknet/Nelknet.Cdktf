using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftCluster
{
    [JsiiInterface(nativeType: typeof(IRedshiftClusterSnapshotCopy), fullyQualifiedName: "aws.redshiftCluster.RedshiftClusterSnapshotCopy")]
    public interface IRedshiftClusterSnapshotCopy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#destination_region RedshiftCluster#destination_region}.</summary>
        [JsiiProperty(name: "destinationRegion", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationRegion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#grant_name RedshiftCluster#grant_name}.</summary>
        [JsiiProperty(name: "grantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GrantName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#retention_period RedshiftCluster#retention_period}.</summary>
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionPeriod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftClusterSnapshotCopy), fullyQualifiedName: "aws.redshiftCluster.RedshiftClusterSnapshotCopy")]
        internal sealed class _Proxy : DeputyBase, aws.RedshiftCluster.IRedshiftClusterSnapshotCopy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#destination_region RedshiftCluster#destination_region}.</summary>
            [JsiiProperty(name: "destinationRegion", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationRegion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#grant_name RedshiftCluster#grant_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "grantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GrantName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#retention_period RedshiftCluster#retention_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionPeriod
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
