using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftScheduledAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionPauseCluster")]
    public class RedshiftScheduledActionTargetActionPauseCluster : aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionPauseCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#cluster_identifier RedshiftScheduledAction#cluster_identifier}.</summary>
        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterIdentifier
        {
            get;
            set;
        }
    }
}
