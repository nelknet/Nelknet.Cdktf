using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2NetworkInsightsAnalysis
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsOutputReference), fullyQualifiedName: "aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsEc2NetworkInsightsAnalysisExplanationsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsEc2NetworkInsightsAnalysisExplanationsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsEc2NetworkInsightsAnalysisExplanationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2NetworkInsightsAnalysisExplanationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "acl", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsAclList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsAclList Acl
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsAclList>()!;
        }

        [JsiiProperty(name: "aclRule", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsAclRuleList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsAclRuleList AclRule
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsAclRuleList>()!;
        }

        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Addresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "attachedTo", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsAttachedToList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsAttachedToList AttachedTo
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsAttachedToList>()!;
        }

        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailabilityZones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "cidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Cidrs
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "classicLoadBalancerListener", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsClassicLoadBalancerListenerList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsClassicLoadBalancerListenerList ClassicLoadBalancerListener
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsClassicLoadBalancerListenerList>()!;
        }

        [JsiiProperty(name: "component", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsComponentList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsComponentList Component
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsComponentList>()!;
        }

        [JsiiProperty(name: "customerGateway", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsCustomerGatewayList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsCustomerGatewayList CustomerGateway
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsCustomerGatewayList>()!;
        }

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsDestinationList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsDestinationList Destination
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsDestinationList>()!;
        }

        [JsiiProperty(name: "destinationVpc", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsDestinationVpcList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsDestinationVpcList DestinationVpc
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsDestinationVpcList>()!;
        }

        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Direction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "elasticLoadBalancerListener", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsElasticLoadBalancerListenerList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsElasticLoadBalancerListenerList ElasticLoadBalancerListener
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsElasticLoadBalancerListenerList>()!;
        }

        [JsiiProperty(name: "explanationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExplanationCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ingressRouteTable", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsIngressRouteTableList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsIngressRouteTableList IngressRouteTable
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsIngressRouteTableList>()!;
        }

        [JsiiProperty(name: "internetGateway", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsInternetGatewayList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsInternetGatewayList InternetGateway
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsInternetGatewayList>()!;
        }

        [JsiiProperty(name: "loadBalancerArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancerListenerPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoadBalancerListenerPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "loadBalancerTargetGroup", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsLoadBalancerTargetGroupList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsLoadBalancerTargetGroupList LoadBalancerTargetGroup
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsLoadBalancerTargetGroupList>()!;
        }

        [JsiiProperty(name: "loadBalancerTargetGroups", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsLoadBalancerTargetGroupsList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsLoadBalancerTargetGroupsList LoadBalancerTargetGroups
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsLoadBalancerTargetGroupsList>()!;
        }

        [JsiiProperty(name: "loadBalancerTargetPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoadBalancerTargetPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "missingComponent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MissingComponent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "natGateway", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsNatGatewayList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsNatGatewayList NatGateway
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsNatGatewayList>()!;
        }

        [JsiiProperty(name: "networkInterface", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsNetworkInterfaceList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsNetworkInterfaceList NetworkInterface
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsNetworkInterfaceList>()!;
        }

        [JsiiProperty(name: "packetField", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PacketField
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "portRanges", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsPortRangesList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsPortRangesList PortRanges
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsPortRangesList>()!;
        }

        [JsiiProperty(name: "prefixList", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsPrefixListStructList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsPrefixListStructList PrefixList
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsPrefixListStructList>()!;
        }

        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Protocols
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "routeTable", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsRouteTableList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsRouteTableList RouteTable
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsRouteTableList>()!;
        }

        [JsiiProperty(name: "routeTableRoute", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsRouteTableRouteList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsRouteTableRouteList RouteTableRoute
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsRouteTableRouteList>()!;
        }

        [JsiiProperty(name: "securityGroup", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSecurityGroupList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSecurityGroupList SecurityGroup
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSecurityGroupList>()!;
        }

        [JsiiProperty(name: "securityGroupRule", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSecurityGroupRuleList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSecurityGroupRuleList SecurityGroupRule
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSecurityGroupRuleList>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSecurityGroupsList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSecurityGroupsList SecurityGroups
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSecurityGroupsList>()!;
        }

        [JsiiProperty(name: "sourceVpc", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSourceVpcList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSourceVpcList SourceVpc
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSourceVpcList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnet", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSubnetList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSubnetList Subnet
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSubnetList>()!;
        }

        [JsiiProperty(name: "subnetRouteTable", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSubnetRouteTableList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSubnetRouteTableList SubnetRouteTable
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsSubnetRouteTableList>()!;
        }

        [JsiiProperty(name: "transitGateway", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsTransitGatewayList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsTransitGatewayList TransitGateway
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsTransitGatewayList>()!;
        }

        [JsiiProperty(name: "transitGatewayAttachment", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsTransitGatewayAttachmentList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsTransitGatewayAttachmentList TransitGatewayAttachment
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsTransitGatewayAttachmentList>()!;
        }

        [JsiiProperty(name: "transitGatewayRouteTable", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsTransitGatewayRouteTableList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsTransitGatewayRouteTableList TransitGatewayRouteTable
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsTransitGatewayRouteTableList>()!;
        }

        [JsiiProperty(name: "transitGatewayRouteTableRoute", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsTransitGatewayRouteTableRouteList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsTransitGatewayRouteTableRouteList TransitGatewayRouteTableRoute
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsTransitGatewayRouteTableRouteList>()!;
        }

        [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpcList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpcList Vpc
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpcList>()!;
        }

        [JsiiProperty(name: "vpcEndpoint", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpcEndpointList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpcEndpointList VpcEndpoint
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpcEndpointList>()!;
        }

        [JsiiProperty(name: "vpcPeeringConnection", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpcPeeringConnectionList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpcPeeringConnectionList VpcPeeringConnection
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpcPeeringConnectionList>()!;
        }

        [JsiiProperty(name: "vpnConnection", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpnConnectionList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpnConnectionList VpnConnection
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpnConnectionList>()!;
        }

        [JsiiProperty(name: "vpnGateway", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpnGatewayList\"}")]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpnGatewayList VpnGateway
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanationsVpnGatewayList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisExplanations\"}", isOptional: true)]
        public virtual aws.DataAwsEc2NetworkInsightsAnalysis.IDataAwsEc2NetworkInsightsAnalysisExplanations? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsEc2NetworkInsightsAnalysis.IDataAwsEc2NetworkInsightsAnalysisExplanations?>();
            set => SetInstanceProperty(value);
        }
    }
}
