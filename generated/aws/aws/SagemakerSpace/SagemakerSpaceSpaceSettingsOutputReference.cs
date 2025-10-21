using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiClass(nativeType: typeof(aws.SagemakerSpace.SagemakerSpaceSpaceSettingsOutputReference), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerSpaceSpaceSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerSpaceSpaceSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerSpaceSpaceSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerSpaceSpaceSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCodeEditorAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettings\"}}]")]
        public virtual void PutCodeEditorAppSettings(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomFileSystem", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystem\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomFileSystem(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystem[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystem).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystem).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJupyterLabAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettings\"}}]")]
        public virtual void PutJupyterLabAppSettings(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJupyterServerAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettings\"}}]")]
        public virtual void PutJupyterServerAppSettings(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterServerAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterServerAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKernelGatewayAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsKernelGatewayAppSettings\"}}]")]
        public virtual void PutKernelGatewayAppSettings(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsKernelGatewayAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsKernelGatewayAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpaceStorageSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettings\"}}]")]
        public virtual void PutSpaceStorageSettings(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAppType")]
        public virtual void ResetAppType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodeEditorAppSettings")]
        public virtual void ResetCodeEditorAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomFileSystem")]
        public virtual void ResetCustomFileSystem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJupyterLabAppSettings")]
        public virtual void ResetJupyterLabAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJupyterServerAppSettings")]
        public virtual void ResetJupyterServerAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKernelGatewayAppSettings")]
        public virtual void ResetKernelGatewayAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpaceStorageSettings")]
        public virtual void ResetSpaceStorageSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "codeEditorAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettingsOutputReference\"}")]
        public virtual aws.SagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettingsOutputReference CodeEditorAppSettings
        {
            get => GetInstanceProperty<aws.SagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "customFileSystem", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystemList\"}")]
        public virtual aws.SagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystemList CustomFileSystem
        {
            get => GetInstanceProperty<aws.SagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystemList>()!;
        }

        [JsiiProperty(name: "jupyterLabAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsOutputReference\"}")]
        public virtual aws.SagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsOutputReference JupyterLabAppSettings
        {
            get => GetInstanceProperty<aws.SagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettingsOutputReference\"}")]
        public virtual aws.SagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettingsOutputReference JupyterServerAppSettings
        {
            get => GetInstanceProperty<aws.SagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsKernelGatewayAppSettingsOutputReference\"}")]
        public virtual aws.SagemakerSpace.SagemakerSpaceSpaceSettingsKernelGatewayAppSettingsOutputReference KernelGatewayAppSettings
        {
            get => GetInstanceProperty<aws.SagemakerSpace.SagemakerSpaceSpaceSettingsKernelGatewayAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "spaceStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsOutputReference\"}")]
        public virtual aws.SagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsOutputReference SpaceStorageSettings
        {
            get => GetInstanceProperty<aws.SagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeEditorAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettings? CodeEditorAppSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customFileSystemInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystem\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomFileSystemInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jupyterLabAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jupyterServerAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterServerAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelGatewayAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsKernelGatewayAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsKernelGatewayAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spaceStorageSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettings\"}", isOptional: true)]
        public virtual aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettings? SpaceStorageSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettings?>();
        }

        [JsiiProperty(name: "appType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettings\"}", isOptional: true)]
        public virtual aws.SagemakerSpace.ISagemakerSpaceSpaceSettings? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
