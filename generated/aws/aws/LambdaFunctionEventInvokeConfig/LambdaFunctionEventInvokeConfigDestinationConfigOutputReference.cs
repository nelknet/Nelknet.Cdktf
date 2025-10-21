using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunctionEventInvokeConfig
{
    [JsiiClass(nativeType: typeof(aws.LambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOutputReference), fullyQualifiedName: "aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LambdaFunctionEventInvokeConfigDestinationConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LambdaFunctionEventInvokeConfigDestinationConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LambdaFunctionEventInvokeConfigDestinationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunctionEventInvokeConfigDestinationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOnFailure", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure\"}}]")]
        public virtual void PutOnFailure(aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOnSuccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess\"}}]")]
        public virtual void PutOnSuccess(aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOnFailure")]
        public virtual void ResetOnFailure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnSuccess")]
        public virtual void ResetOnSuccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnFailureOutputReference\"}")]
        public virtual aws.LambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnFailureOutputReference OnFailure
        {
            get => GetInstanceProperty<aws.LambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnFailureOutputReference>()!;
        }

        [JsiiProperty(name: "onSuccess", typeJson: "{\"fqn\":\"aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccessOutputReference\"}")]
        public virtual aws.LambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccessOutputReference OnSuccess
        {
            get => GetInstanceProperty<aws.LambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccessOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "onFailureInput", typeJson: "{\"fqn\":\"aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure\"}", isOptional: true)]
        public virtual aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure? OnFailureInput
        {
            get => GetInstanceProperty<aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onSuccessInput", typeJson: "{\"fqn\":\"aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess\"}", isOptional: true)]
        public virtual aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess? OnSuccessInput
        {
            get => GetInstanceProperty<aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfig\"}", isOptional: true)]
        public virtual aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfig? InternalValue
        {
            get => GetInstanceProperty<aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
