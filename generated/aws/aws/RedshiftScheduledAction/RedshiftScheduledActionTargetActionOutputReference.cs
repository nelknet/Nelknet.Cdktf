using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftScheduledAction
{
    [JsiiClass(nativeType: typeof(aws.RedshiftScheduledAction.RedshiftScheduledActionTargetActionOutputReference), fullyQualifiedName: "aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RedshiftScheduledActionTargetActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RedshiftScheduledActionTargetActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedshiftScheduledActionTargetActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedshiftScheduledActionTargetActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPauseCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionPauseCluster\"}}]")]
        public virtual void PutPauseCluster(aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionPauseCluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionPauseCluster)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResizeCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionResizeCluster\"}}]")]
        public virtual void PutResizeCluster(aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResizeCluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResizeCluster)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResumeCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionResumeCluster\"}}]")]
        public virtual void PutResumeCluster(aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResumeCluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResumeCluster)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPauseCluster")]
        public virtual void ResetPauseCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResizeCluster")]
        public virtual void ResetResizeCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResumeCluster")]
        public virtual void ResetResumeCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "pauseCluster", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionPauseClusterOutputReference\"}")]
        public virtual aws.RedshiftScheduledAction.RedshiftScheduledActionTargetActionPauseClusterOutputReference PauseCluster
        {
            get => GetInstanceProperty<aws.RedshiftScheduledAction.RedshiftScheduledActionTargetActionPauseClusterOutputReference>()!;
        }

        [JsiiProperty(name: "resizeCluster", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionResizeClusterOutputReference\"}")]
        public virtual aws.RedshiftScheduledAction.RedshiftScheduledActionTargetActionResizeClusterOutputReference ResizeCluster
        {
            get => GetInstanceProperty<aws.RedshiftScheduledAction.RedshiftScheduledActionTargetActionResizeClusterOutputReference>()!;
        }

        [JsiiProperty(name: "resumeCluster", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionResumeClusterOutputReference\"}")]
        public virtual aws.RedshiftScheduledAction.RedshiftScheduledActionTargetActionResumeClusterOutputReference ResumeCluster
        {
            get => GetInstanceProperty<aws.RedshiftScheduledAction.RedshiftScheduledActionTargetActionResumeClusterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pauseClusterInput", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionPauseCluster\"}", isOptional: true)]
        public virtual aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionPauseCluster? PauseClusterInput
        {
            get => GetInstanceProperty<aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionPauseCluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resizeClusterInput", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionResizeCluster\"}", isOptional: true)]
        public virtual aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResizeCluster? ResizeClusterInput
        {
            get => GetInstanceProperty<aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResizeCluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resumeClusterInput", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetActionResumeCluster\"}", isOptional: true)]
        public virtual aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResumeCluster? ResumeClusterInput
        {
            get => GetInstanceProperty<aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetActionResumeCluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.redshiftScheduledAction.RedshiftScheduledActionTargetAction\"}", isOptional: true)]
        public virtual aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetAction? InternalValue
        {
            get => GetInstanceProperty<aws.RedshiftScheduledAction.IRedshiftScheduledActionTargetAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
