using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsMskBrokerNodes
{
    [JsiiClass(nativeType: typeof(aws.DataAwsMskBrokerNodes.DataAwsMskBrokerNodesNodeInfoListStructOutputReference), fullyQualifiedName: "aws.dataAwsMskBrokerNodes.DataAwsMskBrokerNodesNodeInfoListStructOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsMskBrokerNodesNodeInfoListStructOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsMskBrokerNodesNodeInfoListStructOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsMskBrokerNodesNodeInfoListStructOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMskBrokerNodesNodeInfoListStructOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attachedEniId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttachedEniId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "brokerId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BrokerId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "clientSubnet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSubnet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientVpcIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientVpcIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Endpoints
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "nodeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsMskBrokerNodes.DataAwsMskBrokerNodesNodeInfoListStruct\"}", isOptional: true)]
        public virtual aws.DataAwsMskBrokerNodes.IDataAwsMskBrokerNodesNodeInfoListStruct? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsMskBrokerNodes.IDataAwsMskBrokerNodesNodeInfoListStruct?>();
            set => SetInstanceProperty(value);
        }
    }
}
