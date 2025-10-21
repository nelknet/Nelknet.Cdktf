using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpoint
{
    [JsiiClass(nativeType: typeof(aws.SagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyOutputReference), fullyQualifiedName: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerEndpointDeploymentConfigRollingUpdatePolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerEndpointDeploymentConfigRollingUpdatePolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerEndpointDeploymentConfigRollingUpdatePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointDeploymentConfigRollingUpdatePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMaximumBatchSize", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSize\"}}]")]
        public virtual void PutMaximumBatchSize(aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSize @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSize)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRollbackMaximumBatchSize", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize\"}}]")]
        public virtual void PutRollbackMaximumBatchSize(aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMaximumExecutionTimeoutInSeconds")]
        public virtual void ResetMaximumExecutionTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRollbackMaximumBatchSize")]
        public virtual void ResetRollbackMaximumBatchSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "maximumBatchSize", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSizeOutputReference\"}")]
        public virtual aws.SagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSizeOutputReference MaximumBatchSize
        {
            get => GetInstanceProperty<aws.SagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSizeOutputReference>()!;
        }

        [JsiiProperty(name: "rollbackMaximumBatchSize", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSizeOutputReference\"}")]
        public virtual aws.SagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSizeOutputReference RollbackMaximumBatchSize
        {
            get => GetInstanceProperty<aws.SagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSizeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumBatchSizeInput", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSize\"}", isOptional: true)]
        public virtual aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSize? MaximumBatchSizeInput
        {
            get => GetInstanceProperty<aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSize?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumExecutionTimeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumExecutionTimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rollbackMaximumBatchSizeInput", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize\"}", isOptional: true)]
        public virtual aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize? RollbackMaximumBatchSizeInput
        {
            get => GetInstanceProperty<aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitIntervalInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WaitIntervalInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maximumExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumExecutionTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WaitIntervalInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicy\"}", isOptional: true)]
        public virtual aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicy? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
