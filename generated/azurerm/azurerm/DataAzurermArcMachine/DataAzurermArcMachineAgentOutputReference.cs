using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermArcMachine
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermArcMachine.DataAzurermArcMachineAgentOutputReference), fullyQualifiedName: "azurerm.dataAzurermArcMachine.DataAzurermArcMachineAgentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermArcMachineAgentOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermArcMachineAgentOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermArcMachineAgentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermArcMachineAgentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "extensionsAllowList", typeJson: "{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineAgentExtensionsAllowListStructList\"}")]
        public virtual azurerm.DataAzurermArcMachine.DataAzurermArcMachineAgentExtensionsAllowListStructList ExtensionsAllowList
        {
            get => GetInstanceProperty<azurerm.DataAzurermArcMachine.DataAzurermArcMachineAgentExtensionsAllowListStructList>()!;
        }

        [JsiiProperty(name: "extensionsBlockList", typeJson: "{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineAgentExtensionsBlockListStructList\"}")]
        public virtual azurerm.DataAzurermArcMachine.DataAzurermArcMachineAgentExtensionsBlockListStructList ExtensionsBlockList
        {
            get => GetInstanceProperty<azurerm.DataAzurermArcMachine.DataAzurermArcMachineAgentExtensionsBlockListStructList>()!;
        }

        [JsiiProperty(name: "extensionsEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ExtensionsEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "guestConfigurationEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable GuestConfigurationEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "incomingConnectionsPorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IncomingConnectionsPorts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "proxyBypass", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ProxyBypass
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "proxyUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProxyUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineAgent\"}", isOptional: true)]
        public virtual azurerm.DataAzurermArcMachine.IDataAzurermArcMachineAgent? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermArcMachine.IDataAzurermArcMachineAgent?>();
            set => SetInstanceProperty(value);
        }
    }
}
