using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualService
{
    [JsiiClass(nativeType: typeof(aws.AppmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNodeOutputReference), fullyQualifiedName: "aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNodeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualServiceSpecProviderVirtualNodeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualServiceSpecProviderVirtualNodeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshVirtualServiceSpecProviderVirtualNodeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualServiceSpecProviderVirtualNodeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualNodeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualNodeNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "virtualNodeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualNodeName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNode\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualNode? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualNode?>();
            set => SetInstanceProperty(value);
        }
    }
}
