using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAppImageConfig
{
    [JsiiClass(nativeType: typeof(aws.SagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigOutputReference), fullyQualifiedName: "aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerAppImageConfigKernelGatewayImageConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerAppImageConfigKernelGatewayImageConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerAppImageConfigKernelGatewayImageConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerAppImageConfigKernelGatewayImageConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFileSystemConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig\"}}]")]
        public virtual void PutFileSystemConfig(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKernelSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigKernelSpec\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutKernelSpec(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigKernelSpec[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigKernelSpec).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigKernelSpec).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFileSystemConfig")]
        public virtual void ResetFileSystemConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfigOutputReference\"}")]
        public virtual aws.SagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfigOutputReference FileSystemConfig
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfigOutputReference>()!;
        }

        [JsiiProperty(name: "kernelSpec", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigKernelSpecList\"}")]
        public virtual aws.SagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigKernelSpecList KernelSpec
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigKernelSpecList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig\"}", isOptional: true)]
        public virtual aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig? FileSystemConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelSpecInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigKernelSpec\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? KernelSpecInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfig\"}", isOptional: true)]
        public virtual aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
