using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestVirtualNetwork
{
    [JsiiClass(nativeType: typeof(azurerm.DevTestVirtualNetwork.DevTestVirtualNetworkSubnetOutputReference), fullyQualifiedName: "azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DevTestVirtualNetworkSubnetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DevTestVirtualNetworkSubnetOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DevTestVirtualNetworkSubnetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevTestVirtualNetworkSubnetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSharedPublicIpAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddress\"}}]")]
        public virtual void PutSharedPublicIpAddress(azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSharedPublicIpAddress")]
        public virtual void ResetSharedPublicIpAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUseInVirtualMachineCreation")]
        public virtual void ResetUseInVirtualMachineCreation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsePublicIpAddress")]
        public virtual void ResetUsePublicIpAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sharedPublicIpAddress", typeJson: "{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressOutputReference\"}")]
        public virtual azurerm.DevTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressOutputReference SharedPublicIpAddress
        {
            get => GetInstanceProperty<azurerm.DevTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharedPublicIpAddressInput", typeJson: "{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddress\"}", isOptional: true)]
        public virtual azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddress? SharedPublicIpAddressInput
        {
            get => GetInstanceProperty<azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddress?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "useInVirtualMachineCreationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UseInVirtualMachineCreationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usePublicIpAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsePublicIpAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "useInVirtualMachineCreation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UseInVirtualMachineCreation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usePublicIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsePublicIpAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnet\"}", isOptional: true)]
        public virtual azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnet? InternalValue
        {
            get => GetInstanceProperty<azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnet?>();
            set => SetInstanceProperty(value);
        }
    }
}
