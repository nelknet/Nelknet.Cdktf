using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualService
{
    [JsiiClass(nativeType: typeof(aws.AppmeshVirtualService.AppmeshVirtualServiceSpecOutputReference), fullyQualifiedName: "aws.appmeshVirtualService.AppmeshVirtualServiceSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualServiceSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualServiceSpecOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshVirtualServiceSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualServiceSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putProvider", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProvider\"}}]")]
        public virtual void PutProvider(aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProvider @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProvider)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetProvider")]
        public virtual void ResetProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderOutputReference\"}")]
        public virtual aws.AppmeshVirtualService.AppmeshVirtualServiceSpecProviderOutputReference Provider
        {
            get => GetInstanceProperty<aws.AppmeshVirtualService.AppmeshVirtualServiceSpecProviderOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "providerInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProvider\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProvider? ProviderInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProvider?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpec\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualService.IAppmeshVirtualServiceSpec? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshVirtualService.IAppmeshVirtualServiceSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
