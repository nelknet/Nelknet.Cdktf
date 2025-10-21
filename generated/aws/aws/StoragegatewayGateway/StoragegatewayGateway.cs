using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.StoragegatewayGateway
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway aws_storagegateway_gateway}.</summary>
    [JsiiClass(nativeType: typeof(aws.StoragegatewayGateway.StoragegatewayGateway), fullyQualifiedName: "aws.storagegatewayGateway.StoragegatewayGateway", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.storagegatewayGateway.StoragegatewayGatewayConfig\"}}]")]
    public class StoragegatewayGateway : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway aws_storagegateway_gateway} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StoragegatewayGateway(Constructs.Construct scope, string id, aws.StoragegatewayGateway.IStoragegatewayGatewayConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.StoragegatewayGateway.IStoragegatewayGatewayConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayGateway(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayGateway(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a StoragegatewayGateway resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StoragegatewayGateway to import.</param>
        /// <param name="importFromId">The id of the existing StoragegatewayGateway that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StoragegatewayGateway to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StoragegatewayGateway to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StoragegatewayGateway that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StoragegatewayGateway to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.StoragegatewayGateway.StoragegatewayGateway), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putMaintenanceStartTime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.storagegatewayGateway.StoragegatewayGatewayMaintenanceStartTime\"}}]")]
        public virtual void PutMaintenanceStartTime(aws.StoragegatewayGateway.IStoragegatewayGatewayMaintenanceStartTime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.StoragegatewayGateway.IStoragegatewayGatewayMaintenanceStartTime)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSmbActiveDirectorySettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.storagegatewayGateway.StoragegatewayGatewaySmbActiveDirectorySettings\"}}]")]
        public virtual void PutSmbActiveDirectorySettings(aws.StoragegatewayGateway.IStoragegatewayGatewaySmbActiveDirectorySettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.StoragegatewayGateway.IStoragegatewayGatewaySmbActiveDirectorySettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.storagegatewayGateway.StoragegatewayGatewayTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.StoragegatewayGateway.IStoragegatewayGatewayTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.StoragegatewayGateway.IStoragegatewayGatewayTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActivationKey")]
        public virtual void ResetActivationKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAverageDownloadRateLimitInBitsPerSec")]
        public virtual void ResetAverageDownloadRateLimitInBitsPerSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAverageUploadRateLimitInBitsPerSec")]
        public virtual void ResetAverageUploadRateLimitInBitsPerSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudwatchLogGroupArn")]
        public virtual void ResetCloudwatchLogGroupArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGatewayIpAddress")]
        public virtual void ResetGatewayIpAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGatewayType")]
        public virtual void ResetGatewayType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGatewayVpcEndpoint")]
        public virtual void ResetGatewayVpcEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceStartTime")]
        public virtual void ResetMaintenanceStartTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMediumChangerType")]
        public virtual void ResetMediumChangerType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmbActiveDirectorySettings")]
        public virtual void ResetSmbActiveDirectorySettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmbFileShareVisibility")]
        public virtual void ResetSmbFileShareVisibility()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmbGuestPassword")]
        public virtual void ResetSmbGuestPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmbSecurityStrategy")]
        public virtual void ResetSmbSecurityStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTapeDriveType")]
        public virtual void ResetTapeDriveType()
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
        = GetStaticProperty<string>(typeof(aws.StoragegatewayGateway.StoragegatewayGateway))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ec2InstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ec2InstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayNetworkInterface", typeJson: "{\"fqn\":\"aws.storagegatewayGateway.StoragegatewayGatewayGatewayNetworkInterfaceList\"}")]
        public virtual aws.StoragegatewayGateway.StoragegatewayGatewayGatewayNetworkInterfaceList GatewayNetworkInterface
        {
            get => GetInstanceProperty<aws.StoragegatewayGateway.StoragegatewayGatewayGatewayNetworkInterfaceList>()!;
        }

        [JsiiProperty(name: "hostEnvironment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostEnvironment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceStartTime", typeJson: "{\"fqn\":\"aws.storagegatewayGateway.StoragegatewayGatewayMaintenanceStartTimeOutputReference\"}")]
        public virtual aws.StoragegatewayGateway.StoragegatewayGatewayMaintenanceStartTimeOutputReference MaintenanceStartTime
        {
            get => GetInstanceProperty<aws.StoragegatewayGateway.StoragegatewayGatewayMaintenanceStartTimeOutputReference>()!;
        }

        [JsiiProperty(name: "smbActiveDirectorySettings", typeJson: "{\"fqn\":\"aws.storagegatewayGateway.StoragegatewayGatewaySmbActiveDirectorySettingsOutputReference\"}")]
        public virtual aws.StoragegatewayGateway.StoragegatewayGatewaySmbActiveDirectorySettingsOutputReference SmbActiveDirectorySettings
        {
            get => GetInstanceProperty<aws.StoragegatewayGateway.StoragegatewayGatewaySmbActiveDirectorySettingsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.storagegatewayGateway.StoragegatewayGatewayTimeoutsOutputReference\"}")]
        public virtual aws.StoragegatewayGateway.StoragegatewayGatewayTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.StoragegatewayGateway.StoragegatewayGatewayTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activationKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActivationKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "averageDownloadRateLimitInBitsPerSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AverageDownloadRateLimitInBitsPerSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "averageUploadRateLimitInBitsPerSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AverageUploadRateLimitInBitsPerSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogGroupArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudwatchLogGroupArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayIpAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayIpAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayTimezoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayTimezoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayVpcEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayVpcEndpointInput
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
        [JsiiProperty(name: "maintenanceStartTimeInput", typeJson: "{\"fqn\":\"aws.storagegatewayGateway.StoragegatewayGatewayMaintenanceStartTime\"}", isOptional: true)]
        public virtual aws.StoragegatewayGateway.IStoragegatewayGatewayMaintenanceStartTime? MaintenanceStartTimeInput
        {
            get => GetInstanceProperty<aws.StoragegatewayGateway.IStoragegatewayGatewayMaintenanceStartTime?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mediumChangerTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MediumChangerTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smbActiveDirectorySettingsInput", typeJson: "{\"fqn\":\"aws.storagegatewayGateway.StoragegatewayGatewaySmbActiveDirectorySettings\"}", isOptional: true)]
        public virtual aws.StoragegatewayGateway.IStoragegatewayGatewaySmbActiveDirectorySettings? SmbActiveDirectorySettingsInput
        {
            get => GetInstanceProperty<aws.StoragegatewayGateway.IStoragegatewayGatewaySmbActiveDirectorySettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smbFileShareVisibilityInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SmbFileShareVisibilityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smbGuestPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SmbGuestPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smbSecurityStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SmbSecurityStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tapeDriveTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TapeDriveTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.storagegatewayGateway.StoragegatewayGatewayTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "activationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActivationKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "averageDownloadRateLimitInBitsPerSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AverageDownloadRateLimitInBitsPerSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "averageUploadRateLimitInBitsPerSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AverageUploadRateLimitInBitsPerSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudwatchLogGroupArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayIpAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayTimezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayTimezone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayVpcEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayVpcEndpoint
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

        [JsiiProperty(name: "mediumChangerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MediumChangerType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smbFileShareVisibility", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SmbFileShareVisibility
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

        [JsiiProperty(name: "smbGuestPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmbGuestPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smbSecurityStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmbSecurityStrategy
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tapeDriveType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TapeDriveType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
