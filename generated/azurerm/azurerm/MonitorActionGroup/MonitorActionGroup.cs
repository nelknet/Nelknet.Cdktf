using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorActionGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group azurerm_monitor_action_group}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MonitorActionGroup.MonitorActionGroup), fullyQualifiedName: "azurerm.monitorActionGroup.MonitorActionGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupConfig\"}}]")]
    public class MonitorActionGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group azurerm_monitor_action_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MonitorActionGroup(Constructs.Construct scope, string id, azurerm.MonitorActionGroup.IMonitorActionGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MonitorActionGroup.IMonitorActionGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorActionGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorActionGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MonitorActionGroup resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MonitorActionGroup to import.</param>
        /// <param name="importFromId">The id of the existing MonitorActionGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MonitorActionGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MonitorActionGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MonitorActionGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MonitorActionGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.MonitorActionGroup.MonitorActionGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putArmRoleReceiver", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupArmRoleReceiver\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutArmRoleReceiver(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorActionGroup.IMonitorActionGroupArmRoleReceiver[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupArmRoleReceiver).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupArmRoleReceiver).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutomationRunbookReceiver", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAutomationRunbookReceiver\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAutomationRunbookReceiver(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorActionGroup.IMonitorActionGroupAutomationRunbookReceiver[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupAutomationRunbookReceiver).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupAutomationRunbookReceiver).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureAppPushReceiver", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAzureAppPushReceiver\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAzureAppPushReceiver(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorActionGroup.IMonitorActionGroupAzureAppPushReceiver[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupAzureAppPushReceiver).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupAzureAppPushReceiver).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureFunctionReceiver", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAzureFunctionReceiver\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAzureFunctionReceiver(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorActionGroup.IMonitorActionGroupAzureFunctionReceiver[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupAzureFunctionReceiver).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupAzureFunctionReceiver).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailReceiver", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupEmailReceiver\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEmailReceiver(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorActionGroup.IMonitorActionGroupEmailReceiver[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupEmailReceiver).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupEmailReceiver).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEventHubReceiver", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupEventHubReceiver\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEventHubReceiver(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorActionGroup.IMonitorActionGroupEventHubReceiver[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupEventHubReceiver).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupEventHubReceiver).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putItsmReceiver", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupItsmReceiver\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutItsmReceiver(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorActionGroup.IMonitorActionGroupItsmReceiver[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupItsmReceiver).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupItsmReceiver).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogicAppReceiver", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupLogicAppReceiver\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogicAppReceiver(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorActionGroup.IMonitorActionGroupLogicAppReceiver[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupLogicAppReceiver).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupLogicAppReceiver).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSmsReceiver", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupSmsReceiver\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSmsReceiver(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorActionGroup.IMonitorActionGroupSmsReceiver[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupSmsReceiver).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupSmsReceiver).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MonitorActionGroup.IMonitorActionGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorActionGroup.IMonitorActionGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVoiceReceiver", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupVoiceReceiver\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVoiceReceiver(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorActionGroup.IMonitorActionGroupVoiceReceiver[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupVoiceReceiver).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupVoiceReceiver).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebhookReceiver", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupWebhookReceiver\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWebhookReceiver(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorActionGroup.IMonitorActionGroupWebhookReceiver[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupWebhookReceiver).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorActionGroup.IMonitorActionGroupWebhookReceiver).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArmRoleReceiver")]
        public virtual void ResetArmRoleReceiver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomationRunbookReceiver")]
        public virtual void ResetAutomationRunbookReceiver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureAppPushReceiver")]
        public virtual void ResetAzureAppPushReceiver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureFunctionReceiver")]
        public virtual void ResetAzureFunctionReceiver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailReceiver")]
        public virtual void ResetEmailReceiver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventHubReceiver")]
        public virtual void ResetEventHubReceiver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetItsmReceiver")]
        public virtual void ResetItsmReceiver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocation")]
        public virtual void ResetLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogicAppReceiver")]
        public virtual void ResetLogicAppReceiver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmsReceiver")]
        public virtual void ResetSmsReceiver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVoiceReceiver")]
        public virtual void ResetVoiceReceiver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebhookReceiver")]
        public virtual void ResetWebhookReceiver()
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
        = GetStaticProperty<string>(typeof(azurerm.MonitorActionGroup.MonitorActionGroup))!;

        [JsiiProperty(name: "armRoleReceiver", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupArmRoleReceiverList\"}")]
        public virtual azurerm.MonitorActionGroup.MonitorActionGroupArmRoleReceiverList ArmRoleReceiver
        {
            get => GetInstanceProperty<azurerm.MonitorActionGroup.MonitorActionGroupArmRoleReceiverList>()!;
        }

        [JsiiProperty(name: "automationRunbookReceiver", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAutomationRunbookReceiverList\"}")]
        public virtual azurerm.MonitorActionGroup.MonitorActionGroupAutomationRunbookReceiverList AutomationRunbookReceiver
        {
            get => GetInstanceProperty<azurerm.MonitorActionGroup.MonitorActionGroupAutomationRunbookReceiverList>()!;
        }

        [JsiiProperty(name: "azureAppPushReceiver", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAzureAppPushReceiverList\"}")]
        public virtual azurerm.MonitorActionGroup.MonitorActionGroupAzureAppPushReceiverList AzureAppPushReceiver
        {
            get => GetInstanceProperty<azurerm.MonitorActionGroup.MonitorActionGroupAzureAppPushReceiverList>()!;
        }

        [JsiiProperty(name: "azureFunctionReceiver", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAzureFunctionReceiverList\"}")]
        public virtual azurerm.MonitorActionGroup.MonitorActionGroupAzureFunctionReceiverList AzureFunctionReceiver
        {
            get => GetInstanceProperty<azurerm.MonitorActionGroup.MonitorActionGroupAzureFunctionReceiverList>()!;
        }

        [JsiiProperty(name: "emailReceiver", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupEmailReceiverList\"}")]
        public virtual azurerm.MonitorActionGroup.MonitorActionGroupEmailReceiverList EmailReceiver
        {
            get => GetInstanceProperty<azurerm.MonitorActionGroup.MonitorActionGroupEmailReceiverList>()!;
        }

        [JsiiProperty(name: "eventHubReceiver", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupEventHubReceiverList\"}")]
        public virtual azurerm.MonitorActionGroup.MonitorActionGroupEventHubReceiverList EventHubReceiver
        {
            get => GetInstanceProperty<azurerm.MonitorActionGroup.MonitorActionGroupEventHubReceiverList>()!;
        }

        [JsiiProperty(name: "itsmReceiver", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupItsmReceiverList\"}")]
        public virtual azurerm.MonitorActionGroup.MonitorActionGroupItsmReceiverList ItsmReceiver
        {
            get => GetInstanceProperty<azurerm.MonitorActionGroup.MonitorActionGroupItsmReceiverList>()!;
        }

        [JsiiProperty(name: "logicAppReceiver", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupLogicAppReceiverList\"}")]
        public virtual azurerm.MonitorActionGroup.MonitorActionGroupLogicAppReceiverList LogicAppReceiver
        {
            get => GetInstanceProperty<azurerm.MonitorActionGroup.MonitorActionGroupLogicAppReceiverList>()!;
        }

        [JsiiProperty(name: "smsReceiver", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupSmsReceiverList\"}")]
        public virtual azurerm.MonitorActionGroup.MonitorActionGroupSmsReceiverList SmsReceiver
        {
            get => GetInstanceProperty<azurerm.MonitorActionGroup.MonitorActionGroupSmsReceiverList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupTimeoutsOutputReference\"}")]
        public virtual azurerm.MonitorActionGroup.MonitorActionGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MonitorActionGroup.MonitorActionGroupTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "voiceReceiver", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupVoiceReceiverList\"}")]
        public virtual azurerm.MonitorActionGroup.MonitorActionGroupVoiceReceiverList VoiceReceiver
        {
            get => GetInstanceProperty<azurerm.MonitorActionGroup.MonitorActionGroupVoiceReceiverList>()!;
        }

        [JsiiProperty(name: "webhookReceiver", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupWebhookReceiverList\"}")]
        public virtual azurerm.MonitorActionGroup.MonitorActionGroupWebhookReceiverList WebhookReceiver
        {
            get => GetInstanceProperty<azurerm.MonitorActionGroup.MonitorActionGroupWebhookReceiverList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "armRoleReceiverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupArmRoleReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ArmRoleReceiverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automationRunbookReceiverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAutomationRunbookReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AutomationRunbookReceiverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureAppPushReceiverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAzureAppPushReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AzureAppPushReceiverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureFunctionReceiverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAzureFunctionReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AzureFunctionReceiverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailReceiverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupEmailReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EmailReceiverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventHubReceiverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupEventHubReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EventHubReceiverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "itsmReceiverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupItsmReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ItsmReceiverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logicAppReceiverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupLogicAppReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogicAppReceiverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shortNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShortNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsReceiverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupSmsReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SmsReceiverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "voiceReceiverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupVoiceReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VoiceReceiverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webhookReceiverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupWebhookReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WebhookReceiverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
