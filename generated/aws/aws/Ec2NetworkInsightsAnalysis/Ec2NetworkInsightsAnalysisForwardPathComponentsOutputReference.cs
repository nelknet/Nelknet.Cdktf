using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsAnalysis
{
    [JsiiClass(nativeType: typeof(aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutputReference), fullyQualifiedName: "aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Ec2NetworkInsightsAnalysisForwardPathComponentsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Ec2NetworkInsightsAnalysisForwardPathComponentsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected Ec2NetworkInsightsAnalysisForwardPathComponentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2NetworkInsightsAnalysisForwardPathComponentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aclRule", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsAclRuleList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsAclRuleList AclRule
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsAclRuleList>()!;
        }

        [JsiiProperty(name: "additionalDetails", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsAdditionalDetailsList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsAdditionalDetailsList AdditionalDetails
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsAdditionalDetailsList>()!;
        }

        [JsiiProperty(name: "attachedTo", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsAttachedToList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsAttachedToList AttachedTo
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsAttachedToList>()!;
        }

        [JsiiProperty(name: "component", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsComponentList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsComponentList Component
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsComponentList>()!;
        }

        [JsiiProperty(name: "destinationVpc", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsDestinationVpcList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsDestinationVpcList DestinationVpc
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsDestinationVpcList>()!;
        }

        [JsiiProperty(name: "inboundHeader", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsInboundHeaderList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsInboundHeaderList InboundHeader
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsInboundHeaderList>()!;
        }

        [JsiiProperty(name: "outboundHeader", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderList OutboundHeader
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsOutboundHeaderList>()!;
        }

        [JsiiProperty(name: "routeTableRoute", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsRouteTableRouteList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsRouteTableRouteList RouteTableRoute
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsRouteTableRouteList>()!;
        }

        [JsiiProperty(name: "securityGroupRule", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsSecurityGroupRuleList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsSecurityGroupRuleList SecurityGroupRule
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsSecurityGroupRuleList>()!;
        }

        [JsiiProperty(name: "sequenceNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SequenceNumber
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sourceVpc", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsSourceVpcList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsSourceVpcList SourceVpc
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsSourceVpcList>()!;
        }

        [JsiiProperty(name: "subnet", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsSubnetList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsSubnetList Subnet
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsSubnetList>()!;
        }

        [JsiiProperty(name: "transitGateway", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsTransitGatewayList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsTransitGatewayList TransitGateway
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsTransitGatewayList>()!;
        }

        [JsiiProperty(name: "transitGatewayRouteTableRoute", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsTransitGatewayRouteTableRouteList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsTransitGatewayRouteTableRouteList TransitGatewayRouteTableRoute
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsTransitGatewayRouteTableRouteList>()!;
        }

        [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsVpcList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsVpcList Vpc
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponentsVpcList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisForwardPathComponents\"}", isOptional: true)]
        public virtual aws.Ec2NetworkInsightsAnalysis.IEc2NetworkInsightsAnalysisForwardPathComponents? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.IEc2NetworkInsightsAnalysisForwardPathComponents?>();
            set => SetInstanceProperty(value);
        }
    }
}
