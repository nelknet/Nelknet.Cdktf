using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Iothub
{
    [JsiiClass(nativeType: typeof(azurerm.Iothub.IothubNetworkRuleSetIpRuleList), fullyQualifiedName: "azurerm.iothub.IothubNetworkRuleSetIpRuleList", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"wrapsSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class IothubNetworkRuleSetIpRuleList : HashiCorp.Cdktf.ComplexList
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="wrapsSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public IothubNetworkRuleSetIpRuleList(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, bool wrapsSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, wrapsSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, bool wrapsSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, wrapsSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IothubNetworkRuleSetIpRuleList(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IothubNetworkRuleSetIpRuleList(DeputyProps props): base(props)
        {
        }

        /// <param name="index">the index of the item to return.</param>
        [JsiiMethod(name: "get", returnsJson: "{\"type\":{\"fqn\":\"azurerm.iothub.IothubNetworkRuleSetIpRuleOutputReference\"}}", parametersJson: "[{\"docs\":{\"summary\":\"the index of the item to return.\"},\"name\":\"index\",\"type\":{\"primitive\":\"number\"}}]")]
        public virtual azurerm.Iothub.IothubNetworkRuleSetIpRuleOutputReference Get(double index)
        {
            return InvokeInstanceMethod<azurerm.Iothub.IothubNetworkRuleSetIpRuleOutputReference>(new System.Type[]{typeof(double)}, new object[]{index})!;
        }

        /// <summary>The attribute on the parent resource this class is referencing.</summary>
        [JsiiProperty(name: "terraformAttribute", typeJson: "{\"primitive\":\"string\"}")]
        protected override string TerraformAttribute
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <summary>The parent resource.</summary>
        [JsiiProperty(name: "terraformResource", typeJson: "{\"fqn\":\"cdktf.IInterpolatingParent\"}")]
        protected override HashiCorp.Cdktf.IInterpolatingParent TerraformResource
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IInterpolatingParent>()!;
            set => SetInstanceProperty(value);
        }

        /// <summary>whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</summary>
        [JsiiProperty(name: "wrapsSet", typeJson: "{\"primitive\":\"boolean\"}")]
        protected override bool WrapsSet
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubNetworkRuleSetIpRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.Iothub.IIothubNetworkRuleSetIpRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Iothub.IIothubNetworkRuleSetIpRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
