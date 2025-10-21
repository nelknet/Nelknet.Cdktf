using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkConnectionMonitor
{
    [JsiiClass(nativeType: typeof(azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorTestConfigurationOutputReference), fullyQualifiedName: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class NetworkConnectionMonitorTestConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public NetworkConnectionMonitorTestConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected NetworkConnectionMonitorTestConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkConnectionMonitorTestConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHttpConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationHttpConfiguration\"}}]")]
        public virtual void PutHttpConfiguration(azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationHttpConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationHttpConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIcmpConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationIcmpConfiguration\"}}]")]
        public virtual void PutIcmpConfiguration(azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationIcmpConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationIcmpConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSuccessThreshold", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationSuccessThreshold\"}}]")]
        public virtual void PutSuccessThreshold(azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationSuccessThreshold @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationSuccessThreshold)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcpConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationTcpConfiguration\"}}]")]
        public virtual void PutTcpConfiguration(azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationTcpConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationTcpConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHttpConfiguration")]
        public virtual void ResetHttpConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIcmpConfiguration")]
        public virtual void ResetIcmpConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferredIpVersion")]
        public virtual void ResetPreferredIpVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuccessThreshold")]
        public virtual void ResetSuccessThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTcpConfiguration")]
        public virtual void ResetTcpConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTestFrequencyInSeconds")]
        public virtual void ResetTestFrequencyInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "httpConfiguration", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationHttpConfigurationOutputReference\"}")]
        public virtual azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorTestConfigurationHttpConfigurationOutputReference HttpConfiguration
        {
            get => GetInstanceProperty<azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorTestConfigurationHttpConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "icmpConfiguration", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationIcmpConfigurationOutputReference\"}")]
        public virtual azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorTestConfigurationIcmpConfigurationOutputReference IcmpConfiguration
        {
            get => GetInstanceProperty<azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorTestConfigurationIcmpConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "successThreshold", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationSuccessThresholdOutputReference\"}")]
        public virtual azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorTestConfigurationSuccessThresholdOutputReference SuccessThreshold
        {
            get => GetInstanceProperty<azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorTestConfigurationSuccessThresholdOutputReference>()!;
        }

        [JsiiProperty(name: "tcpConfiguration", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationTcpConfigurationOutputReference\"}")]
        public virtual azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorTestConfigurationTcpConfigurationOutputReference TcpConfiguration
        {
            get => GetInstanceProperty<azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorTestConfigurationTcpConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpConfigurationInput", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationHttpConfiguration\"}", isOptional: true)]
        public virtual azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationHttpConfiguration? HttpConfigurationInput
        {
            get => GetInstanceProperty<azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationHttpConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpConfigurationInput", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationIcmpConfiguration\"}", isOptional: true)]
        public virtual azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationIcmpConfiguration? IcmpConfigurationInput
        {
            get => GetInstanceProperty<azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationIcmpConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredIpVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreferredIpVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "successThresholdInput", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationSuccessThreshold\"}", isOptional: true)]
        public virtual azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationSuccessThreshold? SuccessThresholdInput
        {
            get => GetInstanceProperty<azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationSuccessThreshold?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpConfigurationInput", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationTcpConfiguration\"}", isOptional: true)]
        public virtual azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationTcpConfiguration? TcpConfigurationInput
        {
            get => GetInstanceProperty<azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationTcpConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "testFrequencyInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TestFrequencyInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preferredIpVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredIpVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "testFrequencyInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TestFrequencyInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfiguration\"}]}}", isOptional: true)]
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
                        case azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfiguration cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfiguration).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
