using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2NetworkInsightsAnalysis
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsOutputReference), fullyQualifiedName: "aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aclRule", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsAclRuleList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsAclRuleList AclRule
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsAclRuleList>()!;
        }

        [JsiiProperty(name: "additionalDetails", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsAdditionalDetailsList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsAdditionalDetailsList AdditionalDetails
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsAdditionalDetailsList>()!;
        }

        [JsiiProperty(name: "attachedTo", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsAttachedToList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsAttachedToList AttachedTo
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsAttachedToList>()!;
        }

        [JsiiProperty(name: "component", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsComponentList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsComponentList Component
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsComponentList>()!;
        }

        [JsiiProperty(name: "destinationVpc", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsDestinationVpcList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsDestinationVpcList DestinationVpc
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsDestinationVpcList>()!;
        }

        [JsiiProperty(name: "inboundHeader", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsInboundHeaderList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsInboundHeaderList InboundHeader
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsInboundHeaderList>()!;
        }

        [JsiiProperty(name: "outboundHeader", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsOutboundHeaderList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsOutboundHeaderList OutboundHeader
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsOutboundHeaderList>()!;
        }

        [JsiiProperty(name: "routeTableRoute", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsRouteTableRouteList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsRouteTableRouteList RouteTableRoute
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsRouteTableRouteList>()!;
        }

        [JsiiProperty(name: "securityGroupRule", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsSecurityGroupRuleList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsSecurityGroupRuleList SecurityGroupRule
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsSecurityGroupRuleList>()!;
        }

        [JsiiProperty(name: "sequenceNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SequenceNumber
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sourceVpc", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsSourceVpcList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsSourceVpcList SourceVpc
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsSourceVpcList>()!;
        }

        [JsiiProperty(name: "subnet", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsSubnetList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsSubnetList Subnet
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsSubnetList>()!;
        }

        [JsiiProperty(name: "transitGateway", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsTransitGatewayList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsTransitGatewayList TransitGateway
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsTransitGatewayList>()!;
        }

        [JsiiProperty(name: "transitGatewayRouteTableRoute", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsTransitGatewayRouteTableRouteList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsTransitGatewayRouteTableRouteList TransitGatewayRouteTableRoute
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsTransitGatewayRouteTableRouteList>()!;
        }

        [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsVpcList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsVpcList Vpc
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponentsVpcList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisReturnPathComponents\"}", isOptional: true)]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.IDataAwsEc2NetworkInsightsAnalysisReturnPathComponents? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.IDataAwsEc2NetworkInsightsAnalysisReturnPathComponents?>();
            set => SetInstanceProperty(value);
        }
    }
}
