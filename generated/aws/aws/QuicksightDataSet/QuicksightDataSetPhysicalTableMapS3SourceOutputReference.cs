using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceOutputReference), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightDataSetPhysicalTableMapS3SourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightDataSetPhysicalTableMapS3SourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightDataSetPhysicalTableMapS3SourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSetPhysicalTableMapS3SourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInputColumns", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceInputColumns\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInputColumns(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceInputColumns[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceInputColumns).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceInputColumns).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUploadSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceUploadSettings\"}}]")]
        public virtual void PutUploadSettings(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceUploadSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceUploadSettings)}, new object[]{@value});
        }

        [JsiiProperty(name: "inputColumns", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceInputColumnsList\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceInputColumnsList InputColumns
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceInputColumnsList>()!;
        }

        [JsiiProperty(name: "uploadSettings", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceUploadSettingsOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceUploadSettingsOutputReference UploadSettings
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceUploadSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSourceArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputColumnsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceInputColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InputColumnsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uploadSettingsInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceUploadSettings\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceUploadSettings? UploadSettingsInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceUploadSettings?>();
        }

        [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3Source\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3Source? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3Source?>();
            set => SetInstanceProperty(value);
        }
    }
}
