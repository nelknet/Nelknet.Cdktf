using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmMaintenanceWindowTask
{
    [JsiiClass(nativeType: typeof(aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference), fullyQualifiedName: "aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutomationParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters\"}}]")]
        public virtual void PutAutomationParameters(aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters\"}}]")]
        public virtual void PutLambdaParameters(aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRunCommandParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters\"}}]")]
        public virtual void PutRunCommandParameters(aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepFunctionsParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters\"}}]")]
        public virtual void PutStepFunctionsParameters(aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutomationParameters")]
        public virtual void ResetAutomationParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaParameters")]
        public virtual void ResetLambdaParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunCommandParameters")]
        public virtual void ResetRunCommandParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepFunctionsParameters")]
        public virtual void ResetStepFunctionsParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "automationParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersOutputReference\"}")]
        public virtual aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersOutputReference AutomationParameters
        {
            get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersOutputReference>()!;
        }

        [JsiiProperty(name: "lambdaParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParametersOutputReference\"}")]
        public virtual aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParametersOutputReference LambdaParameters
        {
            get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParametersOutputReference>()!;
        }

        [JsiiProperty(name: "runCommandParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersOutputReference\"}")]
        public virtual aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersOutputReference RunCommandParameters
        {
            get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersOutputReference>()!;
        }

        [JsiiProperty(name: "stepFunctionsParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParametersOutputReference\"}")]
        public virtual aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParametersOutputReference StepFunctionsParameters
        {
            get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automationParametersInput", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters\"}", isOptional: true)]
        public virtual aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters? AutomationParametersInput
        {
            get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaParametersInput", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters\"}", isOptional: true)]
        public virtual aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters? LambdaParametersInput
        {
            get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runCommandParametersInput", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters\"}", isOptional: true)]
        public virtual aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters? RunCommandParametersInput
        {
            get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepFunctionsParametersInput", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters\"}", isOptional: true)]
        public virtual aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters? StepFunctionsParametersInput
        {
            get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParameters\"}", isOptional: true)]
        public virtual aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParameters? InternalValue
        {
            get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
