using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGateway
{
    [JsiiClass(nativeType: typeof(azurerm.VirtualNetworkGateway.VirtualNetworkGatewayBgpSettingsOutputReference), fullyQualifiedName: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayBgpSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VirtualNetworkGatewayBgpSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VirtualNetworkGatewayBgpSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VirtualNetworkGatewayBgpSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualNetworkGatewayBgpSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPeeringAddresses", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualNetworkGateway.VirtualNetworkGatewayBgpSettingsPeeringAddresses\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPeeringAddresses(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettingsPeeringAddresses[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettingsPeeringAddresses).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettingsPeeringAddresses).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAsn")]
        public virtual void ResetAsn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPeeringAddresses")]
        public virtual void ResetPeeringAddresses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPeerWeight")]
        public virtual void ResetPeerWeight()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "peeringAddresses", typeJson: "{\"fqn\":\"azurerm.virtualNetworkGateway.VirtualNetworkGatewayBgpSettingsPeeringAddressesList\"}")]
        public virtual azurerm.VirtualNetworkGateway.VirtualNetworkGatewayBgpSettingsPeeringAddressesList PeeringAddresses
        {
            get => GetInstanceProperty<azurerm.VirtualNetworkGateway.VirtualNetworkGatewayBgpSettingsPeeringAddressesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "asnInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AsnInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peeringAddressesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualNetworkGateway.VirtualNetworkGatewayBgpSettingsPeeringAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PeeringAddressesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerWeightInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PeerWeightInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Asn
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeerWeight
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.virtualNetworkGateway.VirtualNetworkGatewayBgpSettings\"}", isOptional: true)]
        public virtual azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
