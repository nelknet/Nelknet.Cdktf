using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.redshiftCluster.RedshiftClusterSnapshotCopy")]
    public class RedshiftClusterSnapshotCopy : aws.RedshiftCluster.IRedshiftClusterSnapshotCopy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#destination_region RedshiftCluster#destination_region}.</summary>
        [JsiiProperty(name: "destinationRegion", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#grant_name RedshiftCluster#grant_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "grantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GrantName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#retention_period RedshiftCluster#retention_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionPeriod
        {
            get;
            set;
        }
    }
}
