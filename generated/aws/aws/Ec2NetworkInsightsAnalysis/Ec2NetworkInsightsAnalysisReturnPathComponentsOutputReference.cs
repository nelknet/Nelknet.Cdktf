using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsAnalysis
{
    [JsiiClass(nativeType: typeof(aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsOutputReference), fullyQualifiedName: "aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Ec2NetworkInsightsAnalysisReturnPathComponentsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Ec2NetworkInsightsAnalysisReturnPathComponentsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected Ec2NetworkInsightsAnalysisReturnPathComponentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2NetworkInsightsAnalysisReturnPathComponentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aclRule", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsAclRuleList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsAclRuleList AclRule
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsAclRuleList>()!;
        }

        [JsiiProperty(name: "additionalDetails", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsAdditionalDetailsList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsAdditionalDetailsList AdditionalDetails
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsAdditionalDetailsList>()!;
        }

        [JsiiProperty(name: "attachedTo", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsAttachedToList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsAttachedToList AttachedTo
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsAttachedToList>()!;
        }

        [JsiiProperty(name: "component", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsComponentList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsComponentList Component
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsComponentList>()!;
        }

        [JsiiProperty(name: "destinationVpc", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsDestinationVpcList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsDestinationVpcList DestinationVpc
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsDestinationVpcList>()!;
        }

        [JsiiProperty(name: "inboundHeader", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsInboundHeaderList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsInboundHeaderList InboundHeader
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsInboundHeaderList>()!;
        }

        [JsiiProperty(name: "outboundHeader", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsOutboundHeaderList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsOutboundHeaderList OutboundHeader
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsOutboundHeaderList>()!;
        }

        [JsiiProperty(name: "routeTableRoute", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsRouteTableRouteList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsRouteTableRouteList RouteTableRoute
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsRouteTableRouteList>()!;
        }

        [JsiiProperty(name: "securityGroupRule", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsSecurityGroupRuleList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsSecurityGroupRuleList SecurityGroupRule
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsSecurityGroupRuleList>()!;
        }

        [JsiiProperty(name: "sequenceNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SequenceNumber
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sourceVpc", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsSourceVpcList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsSourceVpcList SourceVpc
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsSourceVpcList>()!;
        }

        [JsiiProperty(name: "subnet", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsSubnetList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsSubnetList Subnet
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsSubnetList>()!;
        }

        [JsiiProperty(name: "transitGateway", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsTransitGatewayList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsTransitGatewayList TransitGateway
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsTransitGatewayList>()!;
        }

        [JsiiProperty(name: "transitGatewayRouteTableRoute", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsTransitGatewayRouteTableRouteList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsTransitGatewayRouteTableRouteList TransitGatewayRouteTableRoute
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsTransitGatewayRouteTableRouteList>()!;
        }

        [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsVpcList\"}")]
        public virtual aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsVpcList Vpc
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponentsVpcList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisReturnPathComponents\"}", isOptional: true)]
        public virtual aws.Ec2NetworkInsightsAnalysis.IEc2NetworkInsightsAnalysisReturnPathComponents? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsAnalysis.IEc2NetworkInsightsAnalysisReturnPathComponents?>();
            set => SetInstanceProperty(value);
        }
    }
}
