using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiClass(nativeType: typeof(aws.MskReplicator.MskReplicatorKafkaClusterOutputReference), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MskReplicatorKafkaClusterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MskReplicatorKafkaClusterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected MskReplicatorKafkaClusterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskReplicatorKafkaClusterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAmazonMskCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterAmazonMskCluster\"}}]")]
        public virtual void PutAmazonMskCluster(aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterVpcConfig\"}}]")]
        public virtual void PutVpcConfig(aws.MskReplicator.IMskReplicatorKafkaClusterVpcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskReplicator.IMskReplicatorKafkaClusterVpcConfig)}, new object[]{@value});
        }

        [JsiiProperty(name: "amazonMskCluster", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterAmazonMskClusterOutputReference\"}")]
        public virtual aws.MskReplicator.MskReplicatorKafkaClusterAmazonMskClusterOutputReference AmazonMskCluster
        {
            get => GetInstanceProperty<aws.MskReplicator.MskReplicatorKafkaClusterAmazonMskClusterOutputReference>()!;
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterVpcConfigOutputReference\"}")]
        public virtual aws.MskReplicator.MskReplicatorKafkaClusterVpcConfigOutputReference VpcConfig
        {
            get => GetInstanceProperty<aws.MskReplicator.MskReplicatorKafkaClusterVpcConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amazonMskClusterInput", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterAmazonMskCluster\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster? AmazonMskClusterInput
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterVpcConfig\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorKafkaClusterVpcConfig? VpcConfigInput
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterVpcConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaCluster\"}]}}", isOptional: true)]
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
                        case aws.MskReplicator.IMskReplicatorKafkaCluster cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MskReplicator.IMskReplicatorKafkaCluster).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
