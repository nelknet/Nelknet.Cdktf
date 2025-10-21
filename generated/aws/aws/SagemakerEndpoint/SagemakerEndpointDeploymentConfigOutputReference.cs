using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpoint
{
    [JsiiClass(nativeType: typeof(aws.SagemakerEndpoint.SagemakerEndpointDeploymentConfigOutputReference), fullyQualifiedName: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerEndpointDeploymentConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerEndpointDeploymentConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerEndpointDeploymentConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointDeploymentConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutoRollbackConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration\"}}]")]
        public virtual void PutAutoRollbackConfiguration(aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlueGreenUpdatePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy\"}}]")]
        public virtual void PutBlueGreenUpdatePolicy(aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRollingUpdatePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicy\"}}]")]
        public virtual void PutRollingUpdatePolicy(aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoRollbackConfiguration")]
        public virtual void ResetAutoRollbackConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlueGreenUpdatePolicy")]
        public virtual void ResetBlueGreenUpdatePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRollingUpdatePolicy")]
        public virtual void ResetRollingUpdatePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationOutputReference\"}")]
        public virtual aws.SagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationOutputReference AutoRollbackConfiguration
        {
            get => GetInstanceProperty<aws.SagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "blueGreenUpdatePolicy", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyOutputReference\"}")]
        public virtual aws.SagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyOutputReference BlueGreenUpdatePolicy
        {
            get => GetInstanceProperty<aws.SagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "rollingUpdatePolicy", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyOutputReference\"}")]
        public virtual aws.SagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyOutputReference RollingUpdatePolicy
        {
            get => GetInstanceProperty<aws.SagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoRollbackConfigurationInput", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration\"}", isOptional: true)]
        public virtual aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration? AutoRollbackConfigurationInput
        {
            get => GetInstanceProperty<aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blueGreenUpdatePolicyInput", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy\"}", isOptional: true)]
        public virtual aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy? BlueGreenUpdatePolicyInput
        {
            get => GetInstanceProperty<aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rollingUpdatePolicyInput", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicy\"}", isOptional: true)]
        public virtual aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicy? RollingUpdatePolicyInput
        {
            get => GetInstanceProperty<aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfig\"}", isOptional: true)]
        public virtual aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
