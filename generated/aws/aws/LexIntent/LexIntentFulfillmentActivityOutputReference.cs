using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    [JsiiClass(nativeType: typeof(aws.LexIntent.LexIntentFulfillmentActivityOutputReference), fullyQualifiedName: "aws.lexIntent.LexIntentFulfillmentActivityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LexIntentFulfillmentActivityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LexIntentFulfillmentActivityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LexIntentFulfillmentActivityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntentFulfillmentActivityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCodeHook", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lexIntent.LexIntentFulfillmentActivityCodeHook\"}}]")]
        public virtual void PutCodeHook(aws.LexIntent.ILexIntentFulfillmentActivityCodeHook @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LexIntent.ILexIntentFulfillmentActivityCodeHook)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCodeHook")]
        public virtual void ResetCodeHook()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "codeHook", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFulfillmentActivityCodeHookOutputReference\"}")]
        public virtual aws.LexIntent.LexIntentFulfillmentActivityCodeHookOutputReference CodeHook
        {
            get => GetInstanceProperty<aws.LexIntent.LexIntentFulfillmentActivityCodeHookOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeHookInput", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFulfillmentActivityCodeHook\"}", isOptional: true)]
        public virtual aws.LexIntent.ILexIntentFulfillmentActivityCodeHook? CodeHookInput
        {
            get => GetInstanceProperty<aws.LexIntent.ILexIntentFulfillmentActivityCodeHook?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFulfillmentActivity\"}", isOptional: true)]
        public virtual aws.LexIntent.ILexIntentFulfillmentActivity? InternalValue
        {
            get => GetInstanceProperty<aws.LexIntent.ILexIntentFulfillmentActivity?>();
            set => SetInstanceProperty(value);
        }
    }
}
