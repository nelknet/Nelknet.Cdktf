using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiClass(nativeType: typeof(aws.S3Bucket.S3BucketReplicationConfigurationRulesOutputReference), fullyQualifiedName: "aws.s3Bucket.S3BucketReplicationConfigurationRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3BucketReplicationConfigurationRulesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public S3BucketReplicationConfigurationRulesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected S3BucketReplicationConfigurationRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesDestination\"}}]")]
        public virtual void PutDestination(aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesFilter\"}}]")]
        public virtual void PutFilter(aws.S3Bucket.IS3BucketReplicationConfigurationRulesFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3Bucket.IS3BucketReplicationConfigurationRulesFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceSelectionCriteria", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesSourceSelectionCriteria\"}}]")]
        public virtual void PutSourceSelectionCriteria(aws.S3Bucket.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3Bucket.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeleteMarkerReplicationStatus")]
        public virtual void ResetDeleteMarkerReplicationStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriority")]
        public virtual void ResetPriority()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceSelectionCriteria")]
        public virtual void ResetSourceSelectionCriteria()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesDestinationOutputReference\"}")]
        public virtual aws.S3Bucket.S3BucketReplicationConfigurationRulesDestinationOutputReference Destination
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketReplicationConfigurationRulesDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesFilterOutputReference\"}")]
        public virtual aws.S3Bucket.S3BucketReplicationConfigurationRulesFilterOutputReference Filter
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketReplicationConfigurationRulesFilterOutputReference>()!;
        }

        [JsiiProperty(name: "sourceSelectionCriteria", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference\"}")]
        public virtual aws.S3Bucket.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference SourceSelectionCriteria
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteMarkerReplicationStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeleteMarkerReplicationStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesDestination\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestination? DestinationInput
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesFilter\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketReplicationConfigurationRulesFilter? FilterInput
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketReplicationConfigurationRulesFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceSelectionCriteriaInput", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesSourceSelectionCriteria\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria? SourceSelectionCriteriaInput
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "deleteMarkerReplicationStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeleteMarkerReplicationStatus
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

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRules\"}]}}", isOptional: true)]
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
                        case aws.S3Bucket.IS3BucketReplicationConfigurationRules cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3Bucket.IS3BucketReplicationConfigurationRules).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
