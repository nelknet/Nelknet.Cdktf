using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiClass(nativeType: typeof(aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorOutputReference), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableStorageDescriptorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueCatalogTableStorageDescriptorOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueCatalogTableStorageDescriptorOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GlueCatalogTableStorageDescriptorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTableStorageDescriptorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putColumns", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorColumns\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutColumns(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorColumns[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorColumns).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorColumns).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchemaReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReference\"}}]")]
        public virtual void PutSchemaReference(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSerDeInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSerDeInfo\"}}]")]
        public virtual void PutSerDeInfo(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSerDeInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSerDeInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSkewedInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSkewedInfo\"}}]")]
        public virtual void PutSkewedInfo(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSkewedInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSkewedInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSortColumns", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSortColumns\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSortColumns(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSortColumns[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSortColumns).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSortColumns).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiMethod(name: "resetSchemaReference")]
        public virtual void ResetSchemaReference()
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

        [JsiiProperty(name: "columns", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorColumnsList\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorColumnsList Columns
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorColumnsList>()!;
        }

        [JsiiProperty(name: "schemaReference", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference SchemaReference
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference>()!;
        }

        [JsiiProperty(name: "serDeInfo", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSerDeInfoOutputReference\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorSerDeInfoOutputReference SerDeInfo
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorSerDeInfoOutputReference>()!;
        }

        [JsiiProperty(name: "skewedInfo", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSkewedInfoOutputReference\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorSkewedInfoOutputReference SkewedInfo
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorSkewedInfoOutputReference>()!;
        }

        [JsiiProperty(name: "sortColumns", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSortColumnsList\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorSortColumnsList SortColumns
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorSortColumnsList>()!;
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
        [JsiiProperty(name: "columnsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "schemaReferenceInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReference\"}", isOptional: true)]
        public virtual aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReference? SchemaReferenceInput
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serDeInfoInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSerDeInfo\"}", isOptional: true)]
        public virtual aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSerDeInfo? SerDeInfoInput
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSerDeInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skewedInfoInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSkewedInfo\"}", isOptional: true)]
        public virtual aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSkewedInfo? SkewedInfoInput
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSkewedInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sortColumnsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSortColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptor\"}", isOptional: true)]
        public virtual aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptor? InternalValue
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptor?>();
            set => SetInstanceProperty(value);
        }
    }
}
