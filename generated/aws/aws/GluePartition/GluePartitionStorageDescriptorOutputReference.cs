using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GluePartition
{
    [JsiiClass(nativeType: typeof(aws.GluePartition.GluePartitionStorageDescriptorOutputReference), fullyQualifiedName: "aws.gluePartition.GluePartitionStorageDescriptorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GluePartitionStorageDescriptorOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GluePartitionStorageDescriptorOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GluePartitionStorageDescriptorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GluePartitionStorageDescriptorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putColumns", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gluePartition.GluePartitionStorageDescriptorColumns\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutColumns(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GluePartition.IGluePartitionStorageDescriptorColumns[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GluePartition.IGluePartitionStorageDescriptorColumns).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GluePartition.IGluePartitionStorageDescriptorColumns).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSerDeInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.gluePartition.GluePartitionStorageDescriptorSerDeInfo\"}}]")]
        public virtual void PutSerDeInfo(aws.GluePartition.IGluePartitionStorageDescriptorSerDeInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GluePartition.IGluePartitionStorageDescriptorSerDeInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSkewedInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.gluePartition.GluePartitionStorageDescriptorSkewedInfo\"}}]")]
        public virtual void PutSkewedInfo(aws.GluePartition.IGluePartitionStorageDescriptorSkewedInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GluePartition.IGluePartitionStorageDescriptorSkewedInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSortColumns", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gluePartition.GluePartitionStorageDescriptorSortColumns\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSortColumns(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GluePartition.IGluePartitionStorageDescriptorSortColumns[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GluePartition.IGluePartitionStorageDescriptorSortColumns).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GluePartition.IGluePartitionStorageDescriptorSortColumns).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalLocations")]
        public virtual void ResetAdditionalLocations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBucketColumns")]
        public virtual void ResetBucketColumns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetColumns")]
        public virtual void ResetColumns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompressed")]
        public virtual void ResetCompressed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputFormat")]
        public virtual void ResetInputFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocation")]
        public virtual void ResetLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberOfBuckets")]
        public virtual void ResetNumberOfBuckets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputFormat")]
        public virtual void ResetOutputFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSerDeInfo")]
        public virtual void ResetSerDeInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkewedInfo")]
        public virtual void ResetSkewedInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSortColumns")]
        public virtual void ResetSortColumns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStoredAsSubDirectories")]
        public virtual void ResetStoredAsSubDirectories()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "columns", typeJson: "{\"fqn\":\"aws.gluePartition.GluePartitionStorageDescriptorColumnsList\"}")]
        public virtual aws.GluePartition.GluePartitionStorageDescriptorColumnsList Columns
        {
            get => GetInstanceProperty<aws.GluePartition.GluePartitionStorageDescriptorColumnsList>()!;
        }

        [JsiiProperty(name: "serDeInfo", typeJson: "{\"fqn\":\"aws.gluePartition.GluePartitionStorageDescriptorSerDeInfoOutputReference\"}")]
        public virtual aws.GluePartition.GluePartitionStorageDescriptorSerDeInfoOutputReference SerDeInfo
        {
            get => GetInstanceProperty<aws.GluePartition.GluePartitionStorageDescriptorSerDeInfoOutputReference>()!;
        }

        [JsiiProperty(name: "skewedInfo", typeJson: "{\"fqn\":\"aws.gluePartition.GluePartitionStorageDescriptorSkewedInfoOutputReference\"}")]
        public virtual aws.GluePartition.GluePartitionStorageDescriptorSkewedInfoOutputReference SkewedInfo
        {
            get => GetInstanceProperty<aws.GluePartition.GluePartitionStorageDescriptorSkewedInfoOutputReference>()!;
        }

        [JsiiProperty(name: "sortColumns", typeJson: "{\"fqn\":\"aws.gluePartition.GluePartitionStorageDescriptorSortColumnsList\"}")]
        public virtual aws.GluePartition.GluePartitionStorageDescriptorSortColumnsList SortColumns
        {
            get => GetInstanceProperty<aws.GluePartition.GluePartitionStorageDescriptorSortColumnsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalLocationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AdditionalLocationsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketColumnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? BucketColumnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "columnsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gluePartition.GluePartitionStorageDescriptorColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ColumnsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CompressedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberOfBucketsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumberOfBucketsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serDeInfoInput", typeJson: "{\"fqn\":\"aws.gluePartition.GluePartitionStorageDescriptorSerDeInfo\"}", isOptional: true)]
        public virtual aws.GluePartition.IGluePartitionStorageDescriptorSerDeInfo? SerDeInfoInput
        {
            get => GetInstanceProperty<aws.GluePartition.IGluePartitionStorageDescriptorSerDeInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skewedInfoInput", typeJson: "{\"fqn\":\"aws.gluePartition.GluePartitionStorageDescriptorSkewedInfo\"}", isOptional: true)]
        public virtual aws.GluePartition.IGluePartitionStorageDescriptorSkewedInfo? SkewedInfoInput
        {
            get => GetInstanceProperty<aws.GluePartition.IGluePartitionStorageDescriptorSkewedInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sortColumnsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gluePartition.GluePartitionStorageDescriptorSortColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SortColumnsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storedAsSubDirectoriesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? StoredAsSubDirectoriesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "additionalLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdditionalLocations
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucketColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BucketColumns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compressed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Compressed
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

        [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputFormat
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

        [JsiiProperty(name: "numberOfBuckets", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfBuckets
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outputFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storedAsSubDirectories", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object StoredAsSubDirectories
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.gluePartition.GluePartitionStorageDescriptor\"}", isOptional: true)]
        public virtual aws.GluePartition.IGluePartitionStorageDescriptor? InternalValue
        {
            get => GetInstanceProperty<aws.GluePartition.IGluePartitionStorageDescriptor?>();
            set => SetInstanceProperty(value);
        }
    }
}
