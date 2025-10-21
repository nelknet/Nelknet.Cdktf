using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualRouter
{
    [JsiiClass(nativeType: typeof(aws.AppmeshVirtualRouter.AppmeshVirtualRouterSpecListenerOutputReference), fullyQualifiedName: "aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListenerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualRouterSpecListenerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppmeshVirtualRouterSpecListenerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualRouterSpecListenerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualRouterSpecListenerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPortMapping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListenerPortMapping\"}}]")]
        public virtual void PutPortMapping(aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListenerPortMapping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListenerPortMapping)}, new object[]{@value});
        }

        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListenerPortMappingOutputReference\"}")]
        public virtual aws.AppmeshVirtualRouter.AppmeshVirtualRouterSpecListenerPortMappingOutputReference PortMapping
        {
            get => GetInstanceProperty<aws.AppmeshVirtualRouter.AppmeshVirtualRouterSpecListenerPortMappingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "portMappingInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListenerPortMapping\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListenerPortMapping? PortMappingInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListenerPortMapping?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListener\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListener cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListener).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
