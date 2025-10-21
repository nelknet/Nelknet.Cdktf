using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftScheduledAction
{
    [JsiiByValue(fqn: "aws.redshiftScheduledAction.RedshiftScheduledActionTargetAction")]
    public class RedshiftScheduledActionTargetAction : aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetAction
    {
        /// <summary>pause_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#pause_cluster RedshiftScheduledAction#pause_cluster}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pauseCluster", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionPauseCluster\"}", isOptional: true)]
        public aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionPauseCluster? PauseCluster
        {
            get;
            set;
        }

        /// <summary>resize_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#resize_cluster RedshiftScheduledAction#resize_cluster}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resizeCluster", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionResizeCluster\"}", isOptional: true)]
        public aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResizeCluster? ResizeCluster
        {
            get;
            set;
        }

        /// <summary>resume_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#resume_cluster RedshiftScheduledAction#resume_cluster}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resumeCluster", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionResumeCluster\"}", isOptional: true)]
        public aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResumeCluster? ResumeCluster
        {
            get;
            set;
        }
    }
}
