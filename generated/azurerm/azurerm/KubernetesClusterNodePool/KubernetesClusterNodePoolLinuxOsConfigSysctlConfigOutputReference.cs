using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesClusterNodePool
{
    [JsiiClass(nativeType: typeof(azurerm.KubernetesClusterNodePool.KubernetesClusterNodePoolLinuxOsConfigSysctlConfigOutputReference), fullyQualifiedName: "azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolLinuxOsConfigSysctlConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesClusterNodePoolLinuxOsConfigSysctlConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesClusterNodePoolLinuxOsConfigSysctlConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesClusterNodePoolLinuxOsConfigSysctlConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterNodePoolLinuxOsConfigSysctlConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFsAioMaxNr")]
        public virtual void ResetFsAioMaxNr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFsFileMax")]
        public virtual void ResetFsFileMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFsInotifyMaxUserWatches")]
        public virtual void ResetFsInotifyMaxUserWatches()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFsNrOpen")]
        public virtual void ResetFsNrOpen()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKernelThreadsMax")]
        public virtual void ResetKernelThreadsMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetCoreNetdevMaxBacklog")]
        public virtual void ResetNetCoreNetdevMaxBacklog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetCoreOptmemMax")]
        public virtual void ResetNetCoreOptmemMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetCoreRmemDefault")]
        public virtual void ResetNetCoreRmemDefault()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetCoreRmemMax")]
        public virtual void ResetNetCoreRmemMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetCoreSomaxconn")]
        public virtual void ResetNetCoreSomaxconn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetCoreWmemDefault")]
        public virtual void ResetNetCoreWmemDefault()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetCoreWmemMax")]
        public virtual void ResetNetCoreWmemMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetIpv4IpLocalPortRangeMax")]
        public virtual void ResetNetIpv4IpLocalPortRangeMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetIpv4IpLocalPortRangeMin")]
        public virtual void ResetNetIpv4IpLocalPortRangeMin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetIpv4NeighDefaultGcThresh1")]
        public virtual void ResetNetIpv4NeighDefaultGcThresh1()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetIpv4NeighDefaultGcThresh2")]
        public virtual void ResetNetIpv4NeighDefaultGcThresh2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetIpv4NeighDefaultGcThresh3")]
        public virtual void ResetNetIpv4NeighDefaultGcThresh3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetIpv4TcpFinTimeout")]
        public virtual void ResetNetIpv4TcpFinTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetIpv4TcpKeepaliveIntvl")]
        public virtual void ResetNetIpv4TcpKeepaliveIntvl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetIpv4TcpKeepaliveProbes")]
        public virtual void ResetNetIpv4TcpKeepaliveProbes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetIpv4TcpKeepaliveTime")]
        public virtual void ResetNetIpv4TcpKeepaliveTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetIpv4TcpMaxSynBacklog")]
        public virtual void ResetNetIpv4TcpMaxSynBacklog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetIpv4TcpMaxTwBuckets")]
        public virtual void ResetNetIpv4TcpMaxTwBuckets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetIpv4TcpTwReuse")]
        public virtual void ResetNetIpv4TcpTwReuse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetNetfilterNfConntrackBuckets")]
        public virtual void ResetNetNetfilterNfConntrackBuckets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetNetfilterNfConntrackMax")]
        public virtual void ResetNetNetfilterNfConntrackMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmMaxMapCount")]
        public virtual void ResetVmMaxMapCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmSwappiness")]
        public virtual void ResetVmSwappiness()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmVfsCachePressure")]
        public virtual void ResetVmVfsCachePressure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "fsAioMaxNrInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FsAioMaxNrInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fsFileMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FsFileMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fsInotifyMaxUserWatchesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FsInotifyMaxUserWatchesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fsNrOpenInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FsNrOpenInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelThreadsMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? KernelThreadsMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netCoreNetdevMaxBacklogInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetCoreNetdevMaxBacklogInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netCoreOptmemMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetCoreOptmemMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netCoreRmemDefaultInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetCoreRmemDefaultInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netCoreRmemMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetCoreRmemMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netCoreSomaxconnInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetCoreSomaxconnInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netCoreWmemDefaultInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetCoreWmemDefaultInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netCoreWmemMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetCoreWmemMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netIpv4IpLocalPortRangeMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetIpv4IpLocalPortRangeMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netIpv4IpLocalPortRangeMinInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetIpv4IpLocalPortRangeMinInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netIpv4NeighDefaultGcThresh1Input", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetIpv4NeighDefaultGcThresh1Input
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netIpv4NeighDefaultGcThresh2Input", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetIpv4NeighDefaultGcThresh2Input
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netIpv4NeighDefaultGcThresh3Input", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetIpv4NeighDefaultGcThresh3Input
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpFinTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetIpv4TcpFinTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpKeepaliveIntvlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetIpv4TcpKeepaliveIntvlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpKeepaliveProbesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetIpv4TcpKeepaliveProbesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpKeepaliveTimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetIpv4TcpKeepaliveTimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpMaxSynBacklogInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetIpv4TcpMaxSynBacklogInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpMaxTwBucketsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetIpv4TcpMaxTwBucketsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpTwReuseInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? NetIpv4TcpTwReuseInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netNetfilterNfConntrackBucketsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetNetfilterNfConntrackBucketsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netNetfilterNfConntrackMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetNetfilterNfConntrackMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmMaxMapCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VmMaxMapCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmSwappinessInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VmSwappinessInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmVfsCachePressureInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VmVfsCachePressureInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "fsAioMaxNr", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FsAioMaxNr
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fsFileMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FsFileMax
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fsInotifyMaxUserWatches", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FsInotifyMaxUserWatches
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fsNrOpen", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FsNrOpen
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kernelThreadsMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KernelThreadsMax
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netCoreNetdevMaxBacklog", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetCoreNetdevMaxBacklog
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netCoreOptmemMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetCoreOptmemMax
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netCoreRmemDefault", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetCoreRmemDefault
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netCoreRmemMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetCoreRmemMax
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netCoreSomaxconn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetCoreSomaxconn
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netCoreWmemDefault", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetCoreWmemDefault
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netCoreWmemMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetCoreWmemMax
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netIpv4IpLocalPortRangeMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetIpv4IpLocalPortRangeMax
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netIpv4IpLocalPortRangeMin", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetIpv4IpLocalPortRangeMin
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netIpv4NeighDefaultGcThresh1", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetIpv4NeighDefaultGcThresh1
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netIpv4NeighDefaultGcThresh2", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetIpv4NeighDefaultGcThresh2
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netIpv4NeighDefaultGcThresh3", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetIpv4NeighDefaultGcThresh3
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netIpv4TcpFinTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetIpv4TcpFinTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netIpv4TcpKeepaliveIntvl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetIpv4TcpKeepaliveIntvl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netIpv4TcpKeepaliveProbes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetIpv4TcpKeepaliveProbes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netIpv4TcpKeepaliveTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetIpv4TcpKeepaliveTime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netIpv4TcpMaxSynBacklog", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetIpv4TcpMaxSynBacklog
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netIpv4TcpMaxTwBuckets", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetIpv4TcpMaxTwBuckets
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netIpv4TcpTwReuse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object NetIpv4TcpTwReuse
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

        [JsiiProperty(name: "netNetfilterNfConntrackBuckets", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetNetfilterNfConntrackBuckets
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netNetfilterNfConntrackMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetNetfilterNfConntrackMax
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmMaxMapCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VmMaxMapCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmSwappiness", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VmSwappiness
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmVfsCachePressure", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VmVfsCachePressure
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolLinuxOsConfigSysctlConfig\"}", isOptional: true)]
        public virtual azurerm.KubernetesClusterNodePool.IKubernetesClusterNodePoolLinuxOsConfigSysctlConfig? InternalValue
        {
            get => GetInstanceProperty<azurerm.KubernetesClusterNodePool.IKubernetesClusterNodePoolLinuxOsConfigSysctlConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
