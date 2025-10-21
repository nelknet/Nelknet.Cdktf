using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2NetworkInsightsAnalysis
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsOutputReference), fullyQualifiedName: "aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aclRule", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsAclRuleList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsAclRuleList AclRule
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsAclRuleList>()!;
        }

        [JsiiProperty(name: "additionalDetails", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsAdditionalDetailsList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsAdditionalDetailsList AdditionalDetails
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsAdditionalDetailsList>()!;
        }

        [JsiiProperty(name: "attachedTo", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsAttachedToList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsAttachedToList AttachedTo
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsAttachedToList>()!;
        }

        [JsiiProperty(name: "component", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsComponentList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsComponentList Component
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsComponentList>()!;
        }

        [JsiiProperty(name: "destinationVpc", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsDestinationVpcList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsDestinationVpcList DestinationVpc
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsDestinationVpcList>()!;
        }

        [JsiiProperty(name: "inboundHeader", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsInboundHeaderList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsInboundHeaderList InboundHeader
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsInboundHeaderList>()!;
        }

        [JsiiProperty(name: "outboundHeader", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderList OutboundHeader
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderList>()!;
        }

        [JsiiProperty(name: "routeTableRoute", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsRouteTableRouteList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsRouteTableRouteList RouteTableRoute
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsRouteTableRouteList>()!;
        }

        [JsiiProperty(name: "securityGroupRule", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsSecurityGroupRuleList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsSecurityGroupRuleList SecurityGroupRule
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsSecurityGroupRuleList>()!;
        }

        [JsiiProperty(name: "sequenceNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SequenceNumber
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sourceVpc", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsSourceVpcList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsSourceVpcList SourceVpc
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsSourceVpcList>()!;
        }

        [JsiiProperty(name: "subnet", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsSubnetList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsSubnetList Subnet
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsSubnetList>()!;
        }

        [JsiiProperty(name: "transitGateway", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsTransitGatewayList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsTransitGatewayList TransitGateway
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsTransitGatewayList>()!;
        }

        [JsiiProperty(name: "transitGatewayRouteTableRoute", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsTransitGatewayRouteTableRouteList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsTransitGatewayRouteTableRouteList TransitGatewayRouteTableRoute
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsTransitGatewayRouteTableRouteList>()!;
        }

        [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsVpcList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsVpcList Vpc
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponentsVpcList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisForwardPathComponents\"}", isOptional: true)]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.IDataAwsEc2NetworkInsightsAnalysisForwardPathComponents? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.IDataAwsEc2NetworkInsightsAnalysisForwardPathComponents?>();
            set => SetInstanceProperty(value);
        }
    }
}
