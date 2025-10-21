using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftScheduledAction
{
    [JsiiInterface(nativeType: typeof(IRedshiftScheduledActionTargetActionPauseCluster), fullyQualifiedName: "aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionPauseCluster")]
    public interface IRedshiftScheduledActionTargetActionPauseCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#cluster_identifier RedshiftScheduledAction#cluster_identifier}.</summary>
        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterIdentifier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftScheduledActionTargetActionPauseCluster), fullyQualifiedName: "aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionPauseCluster")]
        internal sealed class _Proxy : DeputyBase, aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionPauseCluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#cluster_identifier RedshiftScheduledAction#cluster_identifier}.</summary>
            [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
