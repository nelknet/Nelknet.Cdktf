using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.IotSecurityDeviceGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_device_group azurerm_iot_security_device_group}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroup), fullyQualifiedName: "azurerm.iotSecurityDeviceGroup.IotSecurityDeviceGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.iotSecurityDeviceGroup.IotSecurityDeviceGroupConfig\"}}]")]
    public class IotSecurityDeviceGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_device_group azurerm_iot_security_device_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IotSecurityDeviceGroup(Constructs.Construct scope, string id, azurerm.IotSecurityDeviceGroup.IIotSecurityDeviceGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.IotSecurityDeviceGroup.IIotSecurityDeviceGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotSecurityDeviceGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotSecurityDeviceGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a IotSecurityDeviceGroup resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IotSecurityDeviceGroup to import.</param>
        /// <param name="importFromId">The id of the existing IotSecurityDeviceGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IotSecurityDeviceGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IotSecurityDeviceGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_device_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IotSecurityDeviceGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IotSecurityDeviceGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAllowRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.iotSecurityDeviceGroup.IotSecurityDeviceGroupAllowRule\"}}]")]
        public virtual void PutAllowRule(azurerm.IotSecurityDeviceGroup.IIotSecurityDeviceGroupAllowRule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.IotSecurityDeviceGroup.IIotSecurityDeviceGroupAllowRule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRangeRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iotSecurityDeviceGroup.IotSecurityDeviceGroupRangeRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRangeRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.IotSecurityDeviceGroup.IIotSecurityDeviceGroupRangeRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.IotSecurityDeviceGroup.IIotSecurityDeviceGroupRangeRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.IotSecurityDeviceGroup.IIotSecurityDeviceGroupRangeRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.iotSecurityDeviceGroup.IotSecurityDeviceGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.IotSecurityDeviceGroup.IIotSecurityDeviceGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.IotSecurityDeviceGroup.IIotSecurityDeviceGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllowRule")]
        public virtual void ResetAllowRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRangeRule")]
        public virtual void ResetRangeRule()
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
        = GetStaticProperty<string>(typeof(azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroup))!;

        [JsiiProperty(name: "allowRule", typeJson: "{\"fqn\":\"azurerm.iotSecurityDeviceGroup.IotSecurityDeviceGroupAllowRuleOutputReference\"}")]
        public virtual azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroupAllowRuleOutputReference AllowRule
        {
            get => GetInstanceProperty<azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroupAllowRuleOutputReference>()!;
        }

        [JsiiProperty(name: "rangeRule", typeJson: "{\"fqn\":\"azurerm.iotSecurityDeviceGroup.IotSecurityDeviceGroupRangeRuleList\"}")]
        public virtual azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroupRangeRuleList RangeRule
        {
            get => GetInstanceProperty<azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroupRangeRuleList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.iotSecurityDeviceGroup.IotSecurityDeviceGroupTimeoutsOutputReference\"}")]
        public virtual azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroupTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowRuleInput", typeJson: "{\"fqn\":\"azurerm.iotSecurityDeviceGroup.IotSecurityDeviceGroupAllowRule\"}", isOptional: true)]
        public virtual azurerm.IotSecurityDeviceGroup.IIotSecurityDeviceGroupAllowRule? AllowRuleInput
        {
            get => GetInstanceProperty<azurerm.IotSecurityDeviceGroup.IIotSecurityDeviceGroupAllowRule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iothubIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IothubIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rangeRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iotSecurityDeviceGroup.IotSecurityDeviceGroupRangeRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RangeRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.iotSecurityDeviceGroup.IotSecurityDeviceGroupTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iothubId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IothubId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
