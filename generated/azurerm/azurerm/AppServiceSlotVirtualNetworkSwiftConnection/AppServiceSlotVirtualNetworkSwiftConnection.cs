using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSlotVirtualNetworkSwiftConnection
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_virtual_network_swift_connection azurerm_app_service_slot_virtual_network_swift_connection}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.AppServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnection), fullyQualifiedName: "azurerm.appServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.appServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnectionConfig\"}}]")]
    public class AppServiceSlotVirtualNetworkSwiftConnection : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_virtual_network_swift_connection azurerm_app_service_slot_virtual_network_swift_connection} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AppServiceSlotVirtualNetworkSwiftConnection(Constructs.Construct scope, string id, azurerm.AppServiceSlotVirtualNetworkSwiftConnection.IAppServiceSlotVirtualNetworkSwiftConnectionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.AppServiceSlotVirtualNetworkSwiftConnection.IAppServiceSlotVirtualNetworkSwiftConnectionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppServiceSlotVirtualNetworkSwiftConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppServiceSlotVirtualNetworkSwiftConnection(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a AppServiceSlotVirtualNetworkSwiftConnection resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AppServiceSlotVirtualNetworkSwiftConnection to import.</param>
        /// <param name="importFromId">The id of the existing AppServiceSlotVirtualNetworkSwiftConnection that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AppServiceSlotVirtualNetworkSwiftConnection to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AppServiceSlotVirtualNetworkSwiftConnection to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_virtual_network_swift_connection#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AppServiceSlotVirtualNetworkSwiftConnection that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AppServiceSlotVirtualNetworkSwiftConnection to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.AppServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnection), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.appServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnectionTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.AppServiceSlotVirtualNetworkSwiftConnection.IAppServiceSlotVirtualNetworkSwiftConnectionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AppServiceSlotVirtualNetworkSwiftConnection.IAppServiceSlotVirtualNetworkSwiftConnectionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.AppServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnection))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.appServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnectionTimeoutsOutputReference\"}")]
        public virtual azurerm.AppServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnectionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.AppServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnectionTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appServiceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppServiceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slotNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SlotNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.appServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnectionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "appServiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppServiceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "slotName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SlotName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
