namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcDhcpOptionsAssociationState<'DhcpOptionsId, 'VpcId> = { assignments: ResizeArray<aws.VpcDhcpOptionsAssociation.VpcDhcpOptionsAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options_association">aws_vpc_dhcp_options_association</a>.
    /// </summary>
    type VpcDhcpOptionsAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcDhcpOptionsAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcDhcpOptionsAssociationState<Missing, Missing>)

        member _.Zero(()) : VpcDhcpOptionsAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcDhcpOptionsAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options_association#dhcp_options_id-1">VpcDhcpOptionsAssociation#dhcp_options_id</a>.
        /// </summary>
        [<CustomOperation "dhcp_options_id">]
        member _.DhcpOptionsId(state: VpcDhcpOptionsAssociationState<Missing, 'VpcId>, value: string) : VpcDhcpOptionsAssociationState<Present, 'VpcId> =
            state.assignments.Add(fun config -> config.DhcpOptionsId <- value)
            ({ assignments = state.assignments } : VpcDhcpOptionsAssociationState<Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options_association#vpc_id-1">VpcDhcpOptionsAssociation#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: VpcDhcpOptionsAssociationState<'DhcpOptionsId, Missing>, value: string) : VpcDhcpOptionsAssociationState<'DhcpOptionsId, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : VpcDhcpOptionsAssociationState<'DhcpOptionsId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options_association#id-1">VpcDhcpOptionsAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcDhcpOptionsAssociationState<'DhcpOptionsId, 'VpcId>, value: string) : VpcDhcpOptionsAssociationState<'DhcpOptionsId, 'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcDhcpOptionsAssociationState<'DhcpOptionsId, 'VpcId>

        member _.Run(state: VpcDhcpOptionsAssociationState<Present, Present>) : aws.VpcDhcpOptionsAssociation.VpcDhcpOptionsAssociation =
            let config = aws.VpcDhcpOptionsAssociation.VpcDhcpOptionsAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.VpcDhcpOptionsAssociation.VpcDhcpOptionsAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcDhcpOptionsAssociation: missing required arguments. Must call: dhcp_options_id, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: VpcDhcpOptionsAssociationState<_, _>) : aws.VpcDhcpOptionsAssociation.VpcDhcpOptionsAssociation =
            Unchecked.defaultof<aws.VpcDhcpOptionsAssociation.VpcDhcpOptionsAssociation>
