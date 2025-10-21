using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    [JsiiClass(nativeType: typeof(aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogFileFormatOutputReference), fullyQualifiedName: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogFileFormatOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualGatewaySpecLoggingAccessLogFileFormatOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualGatewaySpecLoggingAccessLogFileFormatOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshVirtualGatewaySpecLoggingAccessLogFileFormatOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecLoggingAccessLogFileFormatOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putJson", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogFileFormatJson\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutJson(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLogFileFormatJson[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLogFileFormatJson).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLogFileFormatJson).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetJson")]
        public virtual void ResetJson()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetText")]
        public virtual void ResetText()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "json", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogFileFormatJsonList\"}")]
        public virtual aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogFileFormatJsonList Json
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogFileFormatJsonList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "jsonInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogFileFormatJson\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? JsonInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "textInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Text
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogFileFormat\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLogFileFormat? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLogFileFormat?>();
            set => SetInstanceProperty(value);
        }
    }
}
