using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiClass(nativeType: typeof(aws.LambdaEventSourceMapping.LambdaEventSourceMappingDestinationConfigOutputReference), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingDestinationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LambdaEventSourceMappingDestinationConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LambdaEventSourceMappingDestinationConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LambdaEventSourceMappingDestinationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaEventSourceMappingDestinationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOnFailure", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingDestinationConfigOnFailure\"}}]")]
        public virtual void PutOnFailure(aws.LambdaEventSourceMapping.ILambdaEventSourceMappingDestinationConfigOnFailure @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaEventSourceMapping.ILambdaEventSourceMappingDestinationConfigOnFailure)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOnFailure")]
        public virtual void ResetOnFailure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingDestinationConfigOnFailureOutputReference\"}")]
        public virtual aws.LambdaEventSourceMapping.LambdaEventSourceMappingDestinationConfigOnFailureOutputReference OnFailure
        {
            get => GetInstanceProperty<aws.LambdaEventSourceMapping.LambdaEventSourceMappingDestinationConfigOnFailureOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "onFailureInput", typeJson: "{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingDestinationConfigOnFailure\"}", isOptional: true)]
        public virtual aws.LambdaEventSourceMapping.ILambdaEventSourceMappingDestinationConfigOnFailure? OnFailureInput
        {
            get => GetInstanceProperty<aws.LambdaEventSourceMapping.ILambdaEventSourceMappingDestinationConfigOnFailure?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingDestinationConfig\"}", isOptional: true)]
        public virtual aws.LambdaEventSourceMapping.ILambdaEventSourceMappingDestinationConfig? InternalValue
        {
            get => GetInstanceProperty<aws.LambdaEventSourceMapping.ILambdaEventSourceMappingDestinationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
