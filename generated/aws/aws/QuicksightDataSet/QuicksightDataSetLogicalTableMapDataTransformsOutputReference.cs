using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsOutputReference), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class QuicksightDataSetLogicalTableMapDataTransformsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public QuicksightDataSetLogicalTableMapDataTransformsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected QuicksightDataSetLogicalTableMapDataTransformsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSetLogicalTableMapDataTransformsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCastColumnTypeOperation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperation\"}}]")]
        public virtual void PutCastColumnTypeOperation(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCreateColumnsOperation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation\"}}]")]
        public virtual void PutCreateColumnsOperation(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilterOperation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsFilterOperation\"}}]")]
        public virtual void PutFilterOperation(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsFilterOperation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsFilterOperation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProjectOperation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsProjectOperation\"}}]")]
        public virtual void PutProjectOperation(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsProjectOperation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsProjectOperation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRenameColumnOperation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation\"}}]")]
        public virtual void PutRenameColumnOperation(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTagColumnOperation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperation\"}}]")]
        public virtual void PutTagColumnOperation(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUntagColumnOperation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation\"}}]")]
        public virtual void PutUntagColumnOperation(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCastColumnTypeOperation")]
        public virtual void ResetCastColumnTypeOperation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateColumnsOperation")]
        public virtual void ResetCreateColumnsOperation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilterOperation")]
        public virtual void ResetFilterOperation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectOperation")]
        public virtual void ResetProjectOperation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRenameColumnOperation")]
        public virtual void ResetRenameColumnOperation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagColumnOperation")]
        public virtual void ResetTagColumnOperation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUntagColumnOperation")]
        public virtual void ResetUntagColumnOperation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "castColumnTypeOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperationOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperationOutputReference CastColumnTypeOperation
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperationOutputReference>()!;
        }

        [JsiiProperty(name: "createColumnsOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperationOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperationOutputReference CreateColumnsOperation
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperationOutputReference>()!;
        }

        [JsiiProperty(name: "filterOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsFilterOperationOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsFilterOperationOutputReference FilterOperation
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsFilterOperationOutputReference>()!;
        }

        [JsiiProperty(name: "projectOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsProjectOperationOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsProjectOperationOutputReference ProjectOperation
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsProjectOperationOutputReference>()!;
        }

        [JsiiProperty(name: "renameColumnOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperationOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperationOutputReference RenameColumnOperation
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperationOutputReference>()!;
        }

        [JsiiProperty(name: "tagColumnOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationOutputReference TagColumnOperation
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationOutputReference>()!;
        }

        [JsiiProperty(name: "untagColumnOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperationOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperationOutputReference UntagColumnOperation
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "castColumnTypeOperationInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperation\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperation? CastColumnTypeOperationInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createColumnsOperationInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation? CreateColumnsOperationInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterOperationInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsFilterOperation\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsFilterOperation? FilterOperationInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsFilterOperation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectOperationInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsProjectOperation\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsProjectOperation? ProjectOperationInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsProjectOperation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "renameColumnOperationInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation? RenameColumnOperationInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagColumnOperationInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperation\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperation? TagColumnOperationInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "untagColumnOperationInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation? UntagColumnOperationInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransforms\"}]}}", isOptional: true)]
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
                        case aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransforms cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransforms).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
