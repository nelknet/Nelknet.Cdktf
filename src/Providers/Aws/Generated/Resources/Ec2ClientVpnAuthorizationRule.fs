namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr> = { assignments: ResizeArray<aws.Ec2ClientVpnAuthorizationRule.Ec2ClientVpnAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_authorization_rule">aws_ec2_client_vpn_authorization_rule</a>.
    /// </summary>
    type Ec2ClientVpnAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2ClientVpnAuthorizationRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2ClientVpnAuthorizationRuleState<Missing, Missing>)

        member _.Zero(()) : Ec2ClientVpnAuthorizationRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2ClientVpnAuthorizationRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_authorization_rule#client_vpn_endpoint_id-1">Ec2ClientVpnAuthorizationRule#client_vpn_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "client_vpn_endpoint_id">]
        member _.ClientVpnEndpointId(state: Ec2ClientVpnAuthorizationRuleState<Missing, 'TargetNetworkCidr>, value: string) : Ec2ClientVpnAuthorizationRuleState<Present, 'TargetNetworkCidr> =
            state.assignments.Add(fun config -> config.ClientVpnEndpointId <- value)
            ({ assignments = state.assignments } : Ec2ClientVpnAuthorizationRuleState<Present, 'TargetNetworkCidr>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_authorization_rule#target_network_cidr-1">Ec2ClientVpnAuthorizationRule#target_network_cidr</a>.
        /// </summary>
        [<CustomOperation "target_network_cidr">]
        member _.TargetNetworkCidr(state: Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, Missing>, value: string) : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, Present> =
            state.assignments.Add(fun config -> config.TargetNetworkCidr <- value)
            ({ assignments = state.assignments } : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_authorization_rule#access_group_id-1">Ec2ClientVpnAuthorizationRule#access_group_id</a>.
        /// </summary>
        [<CustomOperation "access_group_id">]
        member _.AccessGroupId(state: Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr>, value: string) : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr> =
            state.assignments.Add(fun config -> config.AccessGroupId <- value)
            state : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_authorization_rule#authorize_all_groups-1">Ec2ClientVpnAuthorizationRule#authorize_all_groups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "authorize_all_groups">]
        member _.AuthorizeAllGroups(state: Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr>, value: bool) : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr> =
            state.assignments.Add(fun config -> config.AuthorizeAllGroups <- value)
            state : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_authorization_rule#authorize_all_groups-1">Ec2ClientVpnAuthorizationRule#authorize_all_groups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "authorize_all_groups">]
        member _.AuthorizeAllGroups(state: Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr>, value: HashiCorp.Cdktf.IResolvable) : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr> =
            state.assignments.Add(fun config -> config.AuthorizeAllGroups <- value)
            state : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_authorization_rule#description-1">Ec2ClientVpnAuthorizationRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr>, value: string) : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_authorization_rule#id-1">Ec2ClientVpnAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr>, value: string) : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_authorization_rule#timeouts-1">Ec2ClientVpnAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr>, value: aws.Ec2ClientVpnAuthorizationRule.Ec2ClientVpnAuthorizationRuleTimeouts) : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2ClientVpnAuthorizationRuleState<'ClientVpnEndpointId, 'TargetNetworkCidr>

        member _.Run(state: Ec2ClientVpnAuthorizationRuleState<Present, Present>) : aws.Ec2ClientVpnAuthorizationRule.Ec2ClientVpnAuthorizationRule =
            let config = aws.Ec2ClientVpnAuthorizationRule.Ec2ClientVpnAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2ClientVpnAuthorizationRule.Ec2ClientVpnAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2ClientVpnAuthorizationRule: missing required arguments. Must call: client_vpn_endpoint_id, target_network_cidr.", 9999, IsError = true)>]
        member _.Run(_: Ec2ClientVpnAuthorizationRuleState<_, _>) : aws.Ec2ClientVpnAuthorizationRule.Ec2ClientVpnAuthorizationRule =
            Unchecked.defaultof<aws.Ec2ClientVpnAuthorizationRule.Ec2ClientVpnAuthorizationRule>
