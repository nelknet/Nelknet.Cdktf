using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentGroup
{
    [JsiiClass(nativeType: typeof(aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference), fullyQualifiedName: "aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDeploymentReadyOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption\"}}]")]
        public virtual void PutDeploymentReadyOption(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGreenFleetProvisioningOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption\"}}]")]
        public virtual void PutGreenFleetProvisioningOption(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTerminateBlueInstancesOnDeploymentSuccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess\"}}]")]
        public virtual void PutTerminateBlueInstancesOnDeploymentSuccess(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeploymentReadyOption")]
        public virtual void ResetDeploymentReadyOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGreenFleetProvisioningOption")]
        public virtual void ResetGreenFleetProvisioningOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminateBlueInstancesOnDeploymentSuccess")]
        public virtual void ResetTerminateBlueInstancesOnDeploymentSuccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "deploymentReadyOption", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionOutputReference\"}")]
        public virtual aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionOutputReference DeploymentReadyOption
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionOutputReference>()!;
        }

        [JsiiProperty(name: "greenFleetProvisioningOption", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOptionOutputReference\"}")]
        public virtual aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOptionOutputReference GreenFleetProvisioningOption
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOptionOutputReference>()!;
        }

        [JsiiProperty(name: "terminateBlueInstancesOnDeploymentSuccess", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccessOutputReference\"}")]
        public virtual aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccessOutputReference TerminateBlueInstancesOnDeploymentSuccess
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccessOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentReadyOptionInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption? DeploymentReadyOptionInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "greenFleetProvisioningOptionInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption? GreenFleetProvisioningOptionInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminateBlueInstancesOnDeploymentSuccessInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess? TerminateBlueInstancesOnDeploymentSuccessInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
