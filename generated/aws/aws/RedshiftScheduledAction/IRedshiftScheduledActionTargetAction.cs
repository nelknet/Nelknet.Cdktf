using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftScheduledAction
{
    [JsiiInterface(nativeType: typeof(IRedshiftScheduledActionTargetAction), fullyQualifiedName: "aws.redshiftScheduledAction.RedshiftScheduledActionTargetAction")]
    public interface IRedshiftScheduledActionTargetAction
    {
        /// <summary>pause_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#pause_cluster RedshiftScheduledAction#pause_cluster}
        /// </remarks>
        [JsiiProperty(name: "pauseCluster", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionPauseCluster\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionPauseCluster? PauseCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>resize_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#resize_cluster RedshiftScheduledAction#resize_cluster}
        /// </remarks>
        [JsiiProperty(name: "resizeCluster", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionResizeCluster\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResizeCluster? ResizeCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>resume_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#resume_cluster RedshiftScheduledAction#resume_cluster}
        /// </remarks>
        [JsiiProperty(name: "resumeCluster", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionResumeCluster\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResumeCluster? ResumeCluster
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftScheduledActionTargetAction), fullyQualifiedName: "aws.redshiftScheduledAction.RedshiftScheduledActionTargetAction")]
        internal sealed class _Proxy : DeputyBase, aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>pause_cluster block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#pause_cluster RedshiftScheduledAction#pause_cluster}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pauseCluster", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionPauseCluster\"}", isOptional: true)]
            public aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionPauseCluster? PauseCluster
            {
                get => GetInstanceProperty<aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionPauseCluster?>();
            }

            /// <summary>resize_cluster block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#resize_cluster RedshiftScheduledAction#resize_cluster}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resizeCluster", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionResizeCluster\"}", isOptional: true)]
            public aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResizeCluster? ResizeCluster
            {
                get => GetInstanceProperty<aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResizeCluster?>();
            }

            /// <summary>resume_cluster block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#resume_cluster RedshiftScheduledAction#resume_cluster}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resumeCluster", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionResumeCluster\"}", isOptional: true)]
            public aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResumeCluster? ResumeCluster
            {
                get => GetInstanceProperty<aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResumeCluster?>();
            }
        }
    }
}
