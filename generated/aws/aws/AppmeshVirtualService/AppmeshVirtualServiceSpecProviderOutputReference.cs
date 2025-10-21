using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualService
{
    [JsiiClass(nativeType: typeof(aws.AppmeshVirtualService.AppmeshVirtualServiceSpecProviderOutputReference), fullyQualifiedName: "aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualServiceSpecProviderOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualServiceSpecProviderOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshVirtualServiceSpecProviderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualServiceSpecProviderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putVirtualNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNode\"}}]")]
        public virtual void PutVirtualNode(aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVirtualRouter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualRouter\"}}]")]
        public virtual void PutVirtualRouter(aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualRouter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualRouter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetVirtualNode")]
        public virtual void ResetVirtualNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualRouter")]
        public virtual void ResetVirtualRouter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "virtualNode", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNodeOutputReference\"}")]
        public virtual aws.AppmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNodeOutputReference VirtualNode
        {
            get => GetInstanceProperty<aws.AppmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNodeOutputReference>()!;
        }

        [JsiiProperty(name: "virtualRouter", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualRouterOutputReference\"}")]
        public virtual aws.AppmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualRouterOutputReference VirtualRouter
        {
            get => GetInstanceProperty<aws.AppmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualRouterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualNodeInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNode\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualNode? VirtualNodeInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualRouterInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualRouter\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualRouter? VirtualRouterInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualRouter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProvider\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProvider? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProvider?>();
            set => SetInstanceProperty(value);
        }
    }
}
