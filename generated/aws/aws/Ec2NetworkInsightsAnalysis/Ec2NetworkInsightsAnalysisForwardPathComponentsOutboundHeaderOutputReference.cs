using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsAnalysis
{
    [JsiiClass(nativeType: typeof(aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderOutputReference), fullyQualifiedName: "aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "destinationAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DestinationAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "destinationPortRanges", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderDestinationPortRangesList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderDestinationPortRangesList DestinationPortRanges
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderDestinationPortRangesList>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SourceAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sourcePortRanges", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderSourcePortRangesList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderSourcePortRangesList SourcePortRanges
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderSourcePortRangesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeader\"}", isOptional: true)]
        public virtual aws.Ec2NetworkInsightsAnalysis.IEc2NetworkInsightsAnalysisForwardPathComponentsOutboundHeader? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.IEc2NetworkInsightsAnalysisForwardPathComponentsOutboundHeader?>();
            set => SetInstanceProperty(value);
        }
    }
}
