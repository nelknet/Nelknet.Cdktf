using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapOutputReference), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class QuicksightDataSetPhysicalTableMapOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public QuicksightDataSetPhysicalTableMapOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected QuicksightDataSetPhysicalTableMapOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSetPhysicalTableMapOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomSql", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapCustomSql\"}}]")]
        public virtual void PutCustomSql(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapCustomSql @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapCustomSql)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRelationalTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapRelationalTable\"}}]")]
        public virtual void PutRelationalTable(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapRelationalTable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapRelationalTable)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Source", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3Source\"}}]")]
        public virtual void PutS3Source(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3Source @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3Source)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomSql")]
        public virtual void ResetCustomSql()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRelationalTable")]
        public virtual void ResetRelationalTable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Source")]
        public virtual void ResetS3Source()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customSql", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapCustomSqlOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapCustomSqlOutputReference CustomSql
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapCustomSqlOutputReference>()!;
        }

        [JsiiProperty(name: "relationalTable", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapRelationalTableOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapRelationalTableOutputReference RelationalTable
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapRelationalTableOutputReference>()!;
        }

        [JsiiProperty(name: "s3Source", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceOutputReference S3Source
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customSqlInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapCustomSql\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapCustomSql? CustomSqlInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapCustomSql?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "physicalTableMapIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhysicalTableMapIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "relationalTableInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapRelationalTable\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapRelationalTable? RelationalTableInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapRelationalTable?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3SourceInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3Source\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3Source? S3SourceInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3Source?>();
        }

        [JsiiProperty(name: "physicalTableMapId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhysicalTableMapId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMap\"}]}}", isOptional: true)]
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
                        case aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMap cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMap).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
